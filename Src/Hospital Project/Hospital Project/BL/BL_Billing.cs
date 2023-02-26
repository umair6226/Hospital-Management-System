using Hospital_Project.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.BL
{
    class BL_Billing
    {
        public string Message { get; set; }
        public int BillingID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime  DischargeDate { get; set; }
        public double DoctorFees { get; set; }
        public double LabCharges { get; set; }
        public double TreatmentCharges { get; set; }
        public double MedicineCharges { get; set; }
        public double OtherCharges { get; set; }
        public double TotalAmount { get; set; }
        public double RoomorBed { get; set; }

        public void SaveBill(BL_Billing obj)
        {
            SqlParameter[] prm = new SqlParameter[13];
            prm[0] = new SqlParameter("@BillingID", obj.BillingID);
            prm[1] = new SqlParameter("@Date", obj.Date);
            prm[2] = new SqlParameter("@PatientID", obj.PatientID);
            prm[3] = new SqlParameter("@PatientName", obj.PatientName);
            prm[4] = new SqlParameter("@AdmissionDate", obj.AdmissionDate);
            prm[5] = new SqlParameter("@RoomCharges", obj.RoomorBed);
            prm[6] = new SqlParameter("@LabCharges", obj.LabCharges);
            prm[7] = new SqlParameter("@DoctorFees", obj.DoctorFees);
            prm[8] = new SqlParameter("@TreatmentCharges", obj.TreatmentCharges);
            prm[9] = new SqlParameter("@MedicineCharges", obj.MedicineCharges);
            prm[10] = new SqlParameter("@OtherCharges", obj.OtherCharges);
            prm[11] = new SqlParameter("@TotalAmount", obj.TotalAmount);
            prm[12] = new SqlParameter("@Type", obj.BillingID == 0 ? 1 : 6);
            DataAccess.Sp_ExecuteQuery("SP_Billing", prm);
        }
        public BL_Billing LoadPatient(BL_Billing obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@PatientID", obj.PatientID);
            prm[1] = new SqlParameter("@Type", 2);
            DataTable dt= DataAccess.GetDataTable("SP_Billing", prm);
            if (dt.Rows.Count>0)
            {
                obj.PatientName = Convert.ToString(dt.Rows[0]["Patient_Name"]);
                obj.DoctorName= Convert.ToString(dt.Rows[0]["Appointment_With"]);
                obj.Gender= Convert.ToString(dt.Rows[0]["Gender"]);
                obj.Contact= Convert.ToString(dt.Rows[0]["Contact"]);
                obj.DoctorFees= Convert.ToDouble(dt.Rows[0]["Doctor_Fees"]);
            }
            return obj;
        }
        public BL_Billing AdmittedPatient(BL_Billing obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@PatientID", obj.PatientID);
            prm[1] = new SqlParameter("@Type", 3);
            DataTable dt = DataAccess.GetDataTable("SP_Billing", prm);
            if (dt.Rows.Count > 0)
            {
                obj.PatientName = Convert.ToString(dt.Rows[0]["Patient_Name"]);
                obj.DoctorName = Convert.ToString(dt.Rows[0]["Admission_Date"]);
                obj.Gender = Convert.ToString(dt.Rows[0]["Gender"]);
                obj.Contact = Convert.ToString(dt.Rows[0]["Contact"]);
                obj.DoctorFees = Convert.ToDouble(dt.Rows[0]["Doctor_Fees"]);
            }
            return obj;
        }
    }
}
