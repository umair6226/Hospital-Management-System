using Hospital_Project.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmReceipt : Form
    {
        BL_Billing obj = new BL_Billing();
        public static int RegisNo;
        int BillID;
        public static String DocOrDate,DischargeDate;
        public static double DoctorFees, TreatmentFees, Labfess, OtherCharges, RoomFees, MedCharges, Total;

       
        Bitmap bitmap;
        public FrmReceipt()
        {
            InitializeComponent();
            lblDoctorOrDate.Text = DocOrDate;
            lblDischargeDate.Text = DischargeDate;
            Load();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            FillProp();
            obj.SaveBill(obj);

            Graphics graphics = pnlReceipt.CreateGraphics();
            Size size = pnlReceipt.Size;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(pnlReceipt.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

           

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        public void FillProp()
        {
            obj.BillingID = BillID;
            obj.PatientID = RegisNo;
            obj.PatientName = lblPatientName.Text;
            obj.Date = Convert.ToDateTime(lblDate.Text);
            if (DocOrDate == "Admission Date :")
            {              
                obj.AdmissionDate = Convert.ToDateTime(lblDoctorName.Text);
            }
            else
            {
               // obj.AdmissionDate = Convert.ToDateTime(null);
            }
            obj.RoomorBed = Convert.ToDouble(lblRoomCharges.Text);
            obj.LabCharges = Convert.ToDouble(lblRoomCharges.Text);
            obj.DoctorFees = Convert.ToDouble(lblDoctorFees.Text);
            obj.TreatmentCharges = Convert.ToDouble(lblTreatmentCharges.Text);
            obj.MedicineCharges = Convert.ToDouble(lblMedicineCharges.Text);
            obj.OtherCharges = Convert.ToDouble(lblOtherCharges.Text);
            obj.TotalAmount = Convert.ToDouble(Total);
        }
        public void Load()
        {
            obj.PatientID = RegisNo;
            if (DocOrDate== "Admission Date :")
            {
                obj.AdmittedPatient(obj);
            }
            else
            {
                obj.LoadPatient(obj);
            }
            
            lblPatientName.Text = obj.PatientName;
            lblDoctorName.Text = obj.DoctorName;
            lblRegistrationNo.Text = Convert.ToString(obj.PatientID);
            lblGender.Text = obj.Gender;
            lblContact.Text = obj.Contact;
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblDoctorFees.Text = Convert.ToString(DoctorFees);
            lblLabCharges.Text = Convert.ToString(Labfess);
            lblTreatmentCharges.Text = Convert.ToString(TreatmentFees);
            lblMedicineCharges.Text = Convert.ToString(MedCharges);
            lblRoomCharges.Text = Convert.ToString(RoomFees);
            lblOtherCharges.Text = Convert.ToString(OtherCharges);
            Total = DoctorFees + TreatmentFees + Labfess + OtherCharges + RoomFees + MedCharges;
            lblTotal.Text = Convert.ToString(Total+". Rs");
        }
        private void sButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
