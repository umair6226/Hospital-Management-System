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
    class BL_Visit
    {
        public string Name { get; set; }
        public string Doctor { get; set; }
        public string Date { get; set; }
        public string CheckupFor { get; set; }
        public string Gender { get; set; }
        public int PrecautionID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Disease { get; set; }
        public string DrugName { get; set; }
        public string Dose { get; set; }
        public string Duration { get; set; }
        public string Advice { get; set; }
        public string MoreAdvice { get; set; }
        public string DateOfTreatment { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string AdmitIn { get; set; }
        public string FirstTreatment { get; set; }
        public int AdmissionID { get; set; }

        public void Save(BL_Visit obj)
        {
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter("@PrecautionID", obj.PrecautionID);
            prm[1] = new SqlParameter("@PatientID", obj.PatientID);
            prm[2] = new SqlParameter("@Disease", obj.Disease);
            prm[3] = new SqlParameter("@DrugName", obj.DrugName);
            prm[4] = new SqlParameter("@Dose", obj.Dose);
            prm[5] = new SqlParameter("@Duration", obj.Duration);
            prm[6] = new SqlParameter("@Advice", obj.Advice);
            prm[7] = new SqlParameter("@MoreAdvice", obj.MoreAdvice);
            prm[8] = new SqlParameter("@Type", obj.PrecautionID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Precautions", prm);
        }
        public DataTable LoadPrecautions(BL_Visit obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@PatientID", obj.PatientID);
            prm[1] = new SqlParameter("@Type", 4);
            return DataAccess.GetDataTable("SP_Precautions", prm);
        }
        public BL_Visit Load(BL_Visit obj)
        {

            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@PatientName", obj.Name);
            prm[1] = new SqlParameter("@Type", 5);
            DataTable dt = DataAccess.GetDataTable("SP_Appointments", prm);
            if (dt.Rows.Count > 0)
            {
                obj.Doctor = Convert.ToString(dt.Rows[0]["Appointment_With"]);
                obj.Gender = Convert.ToString(dt.Rows[0]["Gender"]);
                obj.Date = Convert.ToString(dt.Rows[0]["Date"]);
                obj.CheckupFor = Convert.ToString(dt.Rows[0]["Checkup_For"]);
            }
            return obj;
        }
       
        public void AdmitPatient(BL_Visit obj)
        {
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@AdmissionID", obj.AdmissionID);
            prm[1] = new SqlParameter("@PatientID", obj.PatientID);
            prm[2] = new SqlParameter("@AdmitIn", obj.AdmitIn);
            prm[3] = new SqlParameter("@FirstTreatment", obj.FirstTreatment);
            prm[4] = new SqlParameter("@AdmissionDate", obj.AdmissionDate);
            prm[5] = new SqlParameter("@DoctorID", obj.DoctorID);
            prm[6] = new SqlParameter("@Type", obj.AdmissionID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Admission", prm);
        }
    }
}
