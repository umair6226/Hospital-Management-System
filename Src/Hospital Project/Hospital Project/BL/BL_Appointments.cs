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
    class BL_Appointments
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Gender { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string CheckupFor { get; set; }
        public string Status { get; set; }
        public void Save(BL_Appointments obj)
        {
            SqlParameter[] prm = new SqlParameter[11];
            prm[0] = new SqlParameter("@AppointmentsID", obj.AppointmentID);
            prm[1] = new SqlParameter("@PatientID", obj.PatientID);
            prm[2] = new SqlParameter("@DoctorID", obj.DoctorID);
            prm[3] = new SqlParameter("@PatientName", obj.PatientName);
            prm[4] = new SqlParameter("@DoctorName", obj.DoctorName);
            prm[5] = new SqlParameter("@Gender", obj.Gender);
            prm[6] = new SqlParameter("@Date", obj.Date);
            prm[7] = new SqlParameter("@Time", obj.Time);
            prm[8] = new SqlParameter("@CheckupFor", obj.CheckupFor);
            prm[9] = new SqlParameter("@Status", obj.Status);
            prm[10] = new SqlParameter("@Type", obj.AppointmentID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Appointments", prm);
        }
        public DataTable LoadData(BL_Appointments obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4);
            return DataAccess.GetDataTable("SP_Appointments", prm);
        }
        public DataTable SearchData(BL_Appointments obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@PatientName", obj.PatientName);
            prm[1] = new SqlParameter("@Type", 3);
            return DataAccess.GetDataTable("SP_Appointments", prm);
        }
        public DataTable Delete(BL_Appointments obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@AppointmentsID", obj.AppointmentID);
            prm[1] = new SqlParameter("@Type", 2);
            return DataAccess.GetDataTable("SP_Appointments", prm);
        }
        public DataTable LoadAllData(BL_Appointments obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 6);
            return DataAccess.GetDataTable("SP_Appointments", prm);
        }
    }
}
