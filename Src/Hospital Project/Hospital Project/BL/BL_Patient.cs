using Hospital_Project.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.BL
{
    class BL_Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string ChronicDiseases { get; set; }
        public string MoreDetails { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int IsDeleted { get; set; }
        public byte[] Picture { get; set; }

         public void Save(BL_Patient obj)
         {
            SqlParameter[] prm = new SqlParameter[17];
            prm[0] = new SqlParameter("@PatientID", obj.PatientID);
            prm[1] = new SqlParameter("@Image", obj.Picture);
            prm[2] = new SqlParameter("@FirstName", obj.FirstName);
            prm[3] = new SqlParameter("@LastName", obj.LastName);
            prm[4] = new SqlParameter("@CNIC", obj.CNIC);
            prm[5] = new SqlParameter("@BloodGroup", obj.BloodGroup);
            prm[6] = new SqlParameter("@Email", obj.Email);
            prm[7] = new SqlParameter("@Age", obj.Age);
            prm[8] = new SqlParameter("@Contact", obj.Contact);
            prm[9] = new SqlParameter("@Gender", obj.Gender);
            prm[10] = new SqlParameter("@Address", obj.Address);
            prm[11] = new SqlParameter("@City", obj.City);
            prm[12] = new SqlParameter("@Country", obj.Country);
            prm[13] = new SqlParameter("@ChronicDiseases", obj.ChronicDiseases);
            prm[14] = new SqlParameter("@MoreDetails", obj.MoreDetails);
            prm[15] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[16] = new SqlParameter("@Type", obj.PatientID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Patient", prm);
        }
        public DataTable LoadData(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4 );
            return DataAccess.GetDataTable("SP_Patient", prm);
        }
        public BL_Patient FullData(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@PatientID", obj.PatientID);
            prm[1] = new SqlParameter("@Type", 6);
            DataTable dt= DataAccess.GetDataTable("SP_Patient", prm);
            if (dt.Rows.Count>0)
            {
                obj.FirstName = Convert.ToString(dt.Rows[0]["First_Name"]);
                obj.LastName = Convert.ToString(dt.Rows[0]["Last_Name"]);
                obj.CNIC = Convert.ToString(dt.Rows[0]["CNIC"]);
                obj.Age = Convert.ToInt32(dt.Rows[0]["Age"]);
                obj.Contact = Convert.ToString(dt.Rows[0]["Contact"]);
                obj.Email = Convert.ToString(dt.Rows[0]["Email"]);
                obj.BloodGroup = Convert.ToString(dt.Rows[0]["Blood_Group"]);
                obj.Gender = Convert.ToString(dt.Rows[0]["Gender"]);
                obj.Address = Convert.ToString(dt.Rows[0]["Address"]);
                obj.City = Convert.ToString(dt.Rows[0]["City"]);
                obj.Country = Convert.ToString(dt.Rows[0]["Country"]);
                obj.Picture = (byte[])dt.Rows[0]["Image"];
                obj.ChronicDiseases = Convert.ToString(dt.Rows[0]["Chronic_Diseases"]);
                obj.MoreDetails = Convert.ToString(dt.Rows[0]["More_Details"]);
            }
            return obj;
        }
        public DataTable SearchData(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@FirstName", obj.FirstName);
            prm[1] = new SqlParameter("@Type", 5);
            return DataAccess.GetDataTable("SP_Patient", prm);
        }
        public void Delete(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@PatientID", obj.PatientID);
            prm[1] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[2] = new SqlParameter("@Type", 3);
            DataAccess.Sp_ExecuteQuery("SP_Patient", prm);
        }
        public DataTable LoadInPatient(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 7);
            return DataAccess.GetDataTable("SP_Patient", prm);
        }

        public DataTable SearchInPatient(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@FirstName", obj.FirstName);
            prm[1] = new SqlParameter("@Type", 8);
            return DataAccess.GetDataTable("SP_Patient", prm);
        }
        public DataTable LoadOutPatient(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 9);
            return DataAccess.GetDataTable("SP_Patient", prm);
        }

        public DataTable SearchOutPatient(BL_Patient obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@FirstName", obj.FirstName);
            prm[1] = new SqlParameter("@Type", 10);
            return DataAccess.GetDataTable("SP_Patient", prm);
        }
    }
}
