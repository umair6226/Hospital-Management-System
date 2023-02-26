using Hospital_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmAppointments : UserControl
    {
        BL_Main x = new BL_Main();
        BL_Appointments obj = new BL_Appointments();
        int AppointmentID;
        public FrmAppointments()
        {
            InitializeComponent();
            LoadComboBox();
            Load();
            LoadAll();
            cmbPatientName.SelectedIndex = -1;
            cmbDoctorName.SelectedIndex = -1;
            BL_Main.GridViewStyle(dataGridView1);
            BL_Main.GridViewStyle(dataGridView2);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Load()
        {
            dataGridView1.DataSource = obj.LoadData(obj);
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
        public void LoadAll()
        {
            dataGridView2.DataSource = obj.LoadAllData(obj);
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
        }
        public void Search()
        {
          
            dataGridView1.DataSource = obj.SearchData(obj);

        }
        public void Clear()
        {
            BL_Main.clear2(this);
        }
        public void FillProp(int id)
        {
            try
            {
                obj.AppointmentID = id;
                obj.PatientName = cmbPatientName.Text;
                obj.DoctorName = cmbDoctorName.Text;
                obj.Date = dtDate.Value;
                obj.Time = cmbTime.Text;
                if (radioButton1.Checked == true)
                {
                    obj.Gender = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    obj.Gender = radioButton2.Text;
                }
                obj.Status = "Pending";
                obj.DoctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);
                obj.PatientID = Convert.ToInt32(cmbPatientName.SelectedValue);
                obj.CheckupFor = cmbCheckupFor.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnBookApnmt_Click(object sender, EventArgs e)
        {
            pnlBooking.Visible = true;
            pnlBookApnmt.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            pnlBooking.Visible = false;
            pnlBookApnmt.Visible = true;
        }
        public void LoadComboBox()
        {
            cmbPatientName.DataSource = x.FillComboBox(1, x);
            cmbPatientName.DisplayMember = "Name";
            cmbPatientName.ValueMember = "PatientID";

            cmbDoctorName.DataSource = x.FillComboBox(2, x);
            cmbDoctorName.DisplayMember = "Name";
            cmbDoctorName.ValueMember = "DoctorID";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (  cmbPatientName.SelectedIndex == -1|| cmbDoctorName.SelectedIndex==-1|| cmbTime.SelectedIndex==-1)
            {
                MessageBox.Show("Please Fill all Empty Fields. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (AppointmentID == 0)
                {
                    FillProp(AppointmentID);
                    obj.Save(obj);
                    MessageBox.Show("Apppointment Booked for  "+obj.PatientName);
                    FrmPatientVisit.DoctorID = Convert.ToInt32(cmbDoctorName.SelectedValue);
                    Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Update Record ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FillProp(AppointmentID);
                        obj.Save(obj);
                        MessageBox.Show("Record Updated Successfully. ");
                        Clear();
                    }
                }
                Load();
            }
        }

        private void cmbPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPatientName_TextChanged(object sender, EventArgs e)
        {
          //  obj.PatientID = Convert.ToInt32(cmbPatientName.ValueMember);
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length>0)
            {
                obj.PatientName = txtSearch.Texts;
                Search();
            }
            else
            {
                Load();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                DialogResult result = MessageBox.Show("Cancel Appointment ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    obj.AppointmentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AppointmentID"].Value);
                    obj.Delete(obj);
                }

            }
            Load();
        }
    }
}
