using Hospital_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmPatients : UserControl
    {
        BL_Patient obj = new BL_Patient();
        public static Boolean Details;
        public static int ID;
        int PatientID;
        public FrmPatients()
        {
            InitializeComponent();
            txtCountry.Texts = "Pakistan";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            BL_Main.GridViewStyle(dataGridView1);
            BL_Main.GridViewStyle(gdvInpatient);
            BL_Main.GridViewStyle(gdvOutPatients);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gdvInpatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gdvOutPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
            if (Details==false)
            {
                pnlRegistration.Visible = true;
                pnlDetails.Visible = false;
            }
            else
            {
                pnlRegistration.Visible = false;
                pnlDetails.Visible = true;
            }
            Load();
            LoadInPatient();
            LoadOutPatient();
            gdvInpatient.Columns[0].Visible = false;
            gdvOutPatients.Columns[0].Visible = false;
        }
        public void Clear()
        {
            BL_Main.clear2(this);
            txtCountry.Texts = "Pakistan";
            for (int i = 0; i < chkChronic.Items.Count; i++)
            {
                chkChronic.SetItemChecked(i, false);
            }
        }
        public void Load()
        {
            dataGridView1.DataSource = obj.LoadData(obj);
           // dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns["Image"].DisplayIndex = 9;
        }
        public void LoadInPatient()
        {
            gdvInpatient.DataSource = obj.LoadInPatient(obj);
            gdvInpatient.Columns[0].Visible = false;
        }
        public void Search()
        {
            dataGridView1.DataSource = obj.SearchData(obj);
           // dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns["Image"].DisplayIndex = 9;
        }
        public void SearchInPatient()
        {
            gdvInpatient.DataSource = obj.SearchInPatient(obj);
        }
        public void SearchOutPatient()
        {
            gdvOutPatients.DataSource = obj.SearchOutPatient(obj);
        }

        public void LoadOutPatient()
        {
            gdvOutPatients.DataSource = obj.LoadOutPatient(obj);
           // gdvOutPatients.Columns[0].Visible = false;
        }
        public void FillProp(int id)
        {
            obj.PatientID = id;
            obj.FirstName = txtFirstName.Texts;
            obj.LastName = txtLastName.Texts;
            obj.CNIC = txtCNIC.Texts;
            obj.Contact = txtPhoneNo.Texts;
            obj.Age = Convert.ToInt32(txtAge.Texts);
            obj.Email = txtEmail.Texts;
            obj.Gender = cmbGender.Text;
            obj.BloodGroup = cmbBloodGroup.Text;
            obj.Address = txtAddress.Texts;
            obj.City = txtCity.Texts;
            obj.Country = txtCountry.Texts;
            obj.IsDeleted = 0;
            obj.MoreDetails = txtMore.Text;
            if (pictureBox1.Image == null)
            {
                obj.Picture = BL_Main.ImageToByte(pictureBox1.BackgroundImage);
            }
            else
            {
                obj.Picture = BL_Main.ImageToByte(pictureBox1.Image);
            }
            for (int i = 0; i < chkChronic.Items.Count; i++)
            {
                if (chkChronic.GetItemChecked(i) == true)
                {
                    obj.ChronicDiseases += chkChronic.Items[i].ToString() + "\n";
                }
            }
        }

        private void txtCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            BL_Main.checkint(e);
        }
       
        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BL_Main.clear2(this);
            txtCountry.Texts = "Pakistan";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Texts == "" || txtCNIC.Texts == "" || txtPhoneNo.Texts == "" ||  txtAddress.Texts == "" || txtCity.Texts == "" || cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill all Empty Fields. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PatientID == 0)
                {
                    FillProp(PatientID);
                    obj.Save(obj);
                    MessageBox.Show("Patient Registered Successfully ");
                    Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Update Record ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FillProp(PatientID);
                        obj.Save(obj);
                        MessageBox.Show("Record Updated Successfully. ");
                        Clear();
                    }
                }
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog FD = new OpenFileDialog();
                FD.Filter = "JPEG Files (*.jpeg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                if (FD.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = FD.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                FrmFullDetails frm = new FrmFullDetails();
                frm.ShowDialog();
            }
            else if (e.ColumnIndex==1)
            {
                pnlDetails.Visible = false;
                pnlRegistration.Visible = true;
                obj.PatientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                PatientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                obj.FullData(obj);
                txtFirstName.Texts = obj.FirstName;
                txtLastName.Texts = obj.LastName;
                txtCNIC.Texts = obj.CNIC;
                txtAge.Texts = Convert.ToString(obj.Age);
                txtPhoneNo.Texts = obj.Contact;
                txtAddress.Texts = obj.Address;
                txtCity.Texts = obj.City;
                txtCountry.Texts = obj.Country;
                txtEmail.Texts = obj.Email;
                cmbBloodGroup.Text = obj.BloodGroup;
                cmbGender.Text = obj.Gender;
                txtMore.Text = obj.MoreDetails;
                pictureBox1.Image = BL_Main.ByteToImage(obj.Picture);
            }
            else if (e.ColumnIndex==2)
            {
                DialogResult result = MessageBox.Show("Are you Sure To Delete this Record ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    obj.PatientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value);
                    obj.IsDeleted = 1;
                    obj.Delete(obj);
                    Load();
                }
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtAllSearch.Texts.Length>0)
            {
                obj.FirstName = txtAllSearch.Texts;
                obj.SearchData(obj);
                Search();
            }
            else
            {
                Load();
            }
        }

        private void txtInSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtInSearch.Texts.Length > 0)
            {
                obj.FirstName = txtInSearch.Texts;
                obj.SearchInPatient(obj);
                SearchInPatient();
            }
            else
            {
                LoadInPatient();
            }
        }

        private void txtOutSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtOutSearch.Texts.Length > 0)
            {
                obj.FirstName = txtOutSearch.Texts;
                obj.SearchOutPatient(obj);
                SearchOutPatient();
            }
            else
            {
                LoadOutPatient();
            }
        }
    }
}
