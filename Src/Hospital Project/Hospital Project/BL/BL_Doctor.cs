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
    class BL_Doctor
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string Contact { get; set; }
        public double DoctorFees { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int IsDeleted { get; set; }
        public byte[] Image { get; set; }

        public void Save(BL_Doctor obj)
        {
            SqlParameter[] prm = new SqlParameter[16];
            prm[0] = new SqlParameter("@DoctorID", obj.DoctorID);
            prm[1] = new SqlParameter("@Image", obj.Image);
            prm[2] = new SqlParameter("@FirstName", obj.FirstName);
            prm[3] = new SqlParameter("@LastName", obj.LastName);
            prm[4] = new SqlParameter("@CNIC", obj.CNIC);
            prm[5] = new SqlParameter("@Qualification", obj.Qualification);
            prm[6] = new SqlParameter("@Specialization", obj.Specialization);
            prm[7] = new SqlParameter("@Email", obj.Email);
            prm[8] = new SqlParameter("@Contact", obj.Contact);
            prm[9] = new SqlParameter("@Gender", obj.Gender);
            prm[10] = new SqlParameter("@Address", obj.Address);
            prm[11] = new SqlParameter("@City", obj.City);
            prm[12] = new SqlParameter("@Country", obj.Country);
            prm[13] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[14] = new SqlParameter("@DoctorFees", obj.DoctorFees);
            prm[15] = new SqlParameter("@Type", obj.DoctorID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Doctor", prm);
        }
        public DataTable LoadData(BL_Doctor obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4);
            return DataAccess.GetDataTable("SP_Doctor", prm);
        }
        public DataTable SearchData(BL_Doctor obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@FirstName", obj.FirstName);
            prm[1] = new SqlParameter("@Type", 5);
            return DataAccess.GetDataTable("SP_Doctor", prm);
        }
        public static void Delete(BL_Doctor obj)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@DoctorID", obj.DoctorID);
            prm[1] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[2] = new SqlParameter("@Type", 3);
            DataAccess.Sp_ExecuteQuery("SP_Doctor", prm);
        }
    }
}
