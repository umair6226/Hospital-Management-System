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
    public partial class FrmPatientVisit : UserControl
    {
        
        BL_Main x = new BL_Main();
        BL_Visit obj = new BL_Visit();
        int AdmissionID;
        public static int DoctorID;
        public FrmPatientVisit()
        {
            InitializeComponent();
            LoadComboBox();
            txtName.SelectedIndex = -1;
            txtAdmisionDate.Texts = Convert.ToString(DateTime.Now);
        }

        public void Clear()
        {
           // txtName.SelectedIndex = -1;
            cmbDrugName.SelectedIndex = -1;
            txtDisease.Texts = "";
            CmbDose.SelectedIndex = -1;
            txtDuration.Text = "";
            txtAdvice.Texts = "";
            txtAdviceDetails.Texts = "";
            txtFirstTrmntRoom.Texts = "";
            cmbRoomType.SelectedIndex = -1;
            CmbRoomNo.SelectedIndex = -1;
            txtFrstTrmntWard.Texts = "";
            cmbWardName.SelectedIndex = -1;
            cmbBedNo.SelectedIndex = -1;
        }
        public void FIllProp()
        {
            obj.PrecautionID = 0;
            obj.PatientID= Convert.ToInt32(txtName.SelectedValue);
            obj.DoctorID = DoctorID;
            obj.Disease = lblDisease.Text;
            obj.DrugName = lblDrugName.Text;
            obj.Dose = lblDose.Text;
            obj.Duration = lblDuration.Text;
            obj.Advice = lblAdvice.Text;
            obj.MoreAdvice = lblMoreAdvice.Text;
        }
       
        public void LoadGridview()
        {
            dgvPrecautions.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPrecautions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrecautions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            obj.PatientID = Convert.ToInt32(txtName.SelectedValue);
            dgvPrecautions.DataSource= obj.LoadPrecautions(obj);
            dgvPrecautions.Columns[0].Visible = false;
            dgvPrecautions.Columns[1].Visible = false;
        }

        public void LoadComboBox()
        {
            txtName.DataSource = x.FillComboBox(3, x);
            txtName.DisplayMember = "Patient_Name";
            txtName.ValueMember = "PatientID";

            cmbDrugName.DataSource = x.FillComboBox(4, x);
            cmbDrugName.DisplayMember = "Name";
            cmbDrugName.ValueMember = "ProductID";
        }

        private void txtName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            obj.Name = txtName.Text;
            obj.Load(obj);
            txtDoctor.Text = obj.Doctor;
            txtDate.Text = obj.Date;
            txtCheckFor.Text = obj.CheckupFor;
            txtGender.Text = obj.Gender;
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            if (cmbDrugName.SelectedIndex == -1 || CmbDose.SelectedIndex == -1 || txtName.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Patient or Drug Name, Duration");
            }
            else
            {
                lblDisease.Text += txtDisease.Texts;
                lblDrugName.Text += cmbDrugName.Text + "\n";
                lblDuration.Text += txtDuration.Text + "\n";
                lblDose.Text += CmbDose.Text + "\n";
                lblAdvice.Text += txtAdvice.Texts + "\n";
                lblMoreAdvice.Text += txtAdviceDetails.Texts + "\n";
                Clear();
            }


        }
       
        private void txtName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obj.PatientID = Convert.ToInt32(txtName.SelectedValue);
            LoadGridview();
        }

        private void rdbtnRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRoom.Checked==true)
            {
                gbRoom.Enabled = true;

            }
            else
            {
                gbRoom.Enabled = false;
            }
        }

        private void rdbtnWard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnWard.Checked == true)
            {
                gbWard.Enabled = true;
            }
            else
            {
                gbWard.Enabled = false;
            }
        }

        private void btnAllotRoom_Click(object sender, EventArgs e)
        {
            if (cmbRoomType.SelectedIndex==-1||CmbRoomNo.SelectedIndex==-1|txtFirstTrmntRoom.Texts=="")
            {
                MessageBox.Show("Please Select Room Type or Room no","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                obj.PatientID = Convert.ToInt32(txtName.SelectedValue);
                obj.AdmitIn = cmbRoomType.Text + " " + CmbRoomNo.Text;
                obj.FirstTreatment = txtFirstTrmntRoom.Texts;
                obj.AdmissionDate = DateTime.Now;
                obj.AdmissionID = AdmissionID;
                obj.AdmitPatient(obj);
                MessageBox.Show("Patient Admitted Successfully");
                Clear();
            }
        }

        private void btnAllotBed_Click(object sender, EventArgs e)
        {
            if (cmbBedNo.SelectedIndex == -1 || cmbWardName.SelectedIndex == -1 | txtFrstTrmntWard.Texts == "")
            {
                MessageBox.Show("Please Select Ward or Bed no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                obj.PatientID = Convert.ToInt32(txtName.SelectedValue);
                obj.AdmitIn = cmbWardName.Text + " Bed " + cmbBedNo.Text;
                obj.FirstTreatment = txtFrstTrmntWard.Texts;
                obj.AdmissionDate = DateTime.Now;
                obj.AdmissionID = AdmissionID;
                obj.AdmitPatient(obj);
                MessageBox.Show("Patient Admitted Successfully");
                Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FIllProp();
            obj.Save(obj);
            Clear();
            LoadGridview();
        }
    }
}
