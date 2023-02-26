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
    class BL_Staffs
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Qualification { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Post { get; set; }
        public string Status { get; set; }
        public int IsDeleted { get; set; }
        public byte[] Image { get; set; }
        public void Save(BL_Staffs obj)
        {
            SqlParameter[] prm = new SqlParameter[13];
            prm[0] = new SqlParameter("@StaffID", obj.StaffID);
            prm[1] = new SqlParameter("@Image", obj.Image);
            prm[2] = new SqlParameter("@Name", obj.Name);
            prm[3] = new SqlParameter("@CNIC", obj.CNIC);
            prm[4] = new SqlParameter("@Qualification", obj.Qualification);
            prm[5] = new SqlParameter("@Email", obj.Email);
            prm[6] = new SqlParameter("@Contact", obj.Contact);
            prm[7] = new SqlParameter("@Gender", obj.Gender);
            prm[8] = new SqlParameter("@Address", obj.Address);
            prm[9] = new SqlParameter("@Post", obj.Post);
            prm[10] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[11] = new SqlParameter("@Status", obj.Status);
            prm[12] = new SqlParameter("@Type", obj.StaffID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Staff", prm);
        }
        public DataTable LoadData(BL_Staffs obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4);
            return DataAccess.GetDataTable("SP_Staff", prm);
        }
        public static void Delete(BL_Staffs obj)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@StaffID", obj.StaffID);
            prm[1] = new SqlParameter("@IsDeleted", obj.IsDeleted);
            prm[2] = new SqlParameter("@Type", 3);
            DataAccess.Sp_ExecuteQuery("SP_Doctor", prm);
        }
    }
}
