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
    public partial class FrmOPBilling : UserControl
    {
        BL_Billing obj = new BL_Billing();
        int BilliID;
        double DoctorFees, LabCharges, TreatmentCharges, MedicineCharges, OtherCharges, TotalAmount;
       
       

        public FrmOPBilling()
        {
            InitializeComponent();
            txtDate.Texts = DateTime.Now.ToLongDateString();
            FrmReceipt.DocOrDate = "Name of Doctor :";
            FrmReceipt.DischargeDate = "Date :";
            Clear();
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            FrmReceipt.RegisNo= Convert.ToInt32(txtRegistrationID.Texts);
            FrmReceipt.DoctorFees = Convert.ToDouble(txtDoctorFees.Texts);
            FrmReceipt.Labfess = Convert.ToDouble(txtLabFees.Texts);
            FrmReceipt.TreatmentFees = Convert.ToDouble(txtTreatmentFees.Texts);
            FrmReceipt.MedCharges = Convert.ToDouble(txtMedFees.Texts);
            FrmReceipt.OtherCharges = Convert.ToDouble(txtOtherFees.Texts);
            FrmReceipt.Total = Convert.ToDouble(txtTotalAmount.Texts);
            FrmReceipt.RoomFees = Convert.ToDouble("0.00");
            FrmReceipt.Total = Convert.ToDouble(txtTotalAmount.Texts);
            FrmReceipt frm = new FrmReceipt();
            frm.ShowDialog();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            CountTotal();
        }

        private void txtDoctorFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            BL_Main.checkint(e);
        }


        public void Clear()
        {
            txtDoctorFees.Texts = "0.00";
            txtLabFees.Texts = "0.00";
            txtMedFees.Texts = "0.00";
            txtOtherFees.Texts = "0.00";
            txtTreatmentFees.Texts = "0.00";
            txtRegistrationID.Texts = "";
            txtDName.Texts = "";
            txtGender.Texts = "";
            txtContact.Texts = "";
            btnTotal.Enabled = false;
            btnGenerateBill.Enabled = false;
        }
        public void CountTotal()
        {
            if (txtDoctorFees.Texts!=""||txtLabFees.Texts!=""||txtMedFees.Texts!=""||txtOtherFees.Texts!=""||txtTreatmentFees.Texts!="")
            {
                DoctorFees = Convert.ToDouble(txtDoctorFees.Texts);
                LabCharges = Convert.ToDouble(txtLabFees.Texts);
                TreatmentCharges = Convert.ToDouble(txtTreatmentFees.Texts);
                MedicineCharges = Convert.ToDouble(txtMedFees.Texts);
                OtherCharges = Convert.ToDouble(txtOtherFees.Texts);
                TotalAmount = DoctorFees + LabCharges + TreatmentCharges + MedicineCharges + OtherCharges;
                txtTotalAmount.Texts = Convert.ToString(TotalAmount);
            }
           
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtRegistrationID.Texts=="")
            {
                MessageBox.Show("Please Enter Patient Registration ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                obj.PatientID = Convert.ToInt32(txtRegistrationID.Texts);
                obj.LoadPatient(obj);
                if (obj.PatientName!=null)
                {
                    txtPName.Texts = obj.PatientName;
                    txtDName.Texts = obj.DoctorName;
                    txtGender.Texts = obj.Gender;
                    txtContact.Texts = obj.Contact;
                    txtDoctorFees.Texts = Convert.ToString(obj.DoctorFees);
                    CountTotal();

                    btnTotal.Enabled = true;
                    btnGenerateBill.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Patient not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
           
        }
    }
}
