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
    class BL_Users
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string AccountType { get; set; }
        public string Status { get; set; }
        public Boolean IsAdmin { get; set; }
        public void Save(BL_Users obj)
        {
            SqlParameter[] prm = new SqlParameter[12];
            prm[0] = new SqlParameter("@UserID", obj.UserID);
            prm[1] = new SqlParameter("@FirstName", obj.FirstName);
            prm[2] = new SqlParameter("@LastName", obj.LastName);
            prm[3] = new SqlParameter("@Contact", obj.Contact);
            prm[4] = new SqlParameter("@Email", obj.Email);
            prm[5] = new SqlParameter("@UserName", obj.UserName);
            prm[6] = new SqlParameter("@Password", obj.Password);
            prm[7] = new SqlParameter("@Gender", obj.Gender);
            prm[8] = new SqlParameter("@AcountType", obj.AccountType);
            prm[9] = new SqlParameter("@AcountStatus", obj.Status);
            prm[10] = new SqlParameter("@IsAdmin", obj.IsAdmin);
            prm[11] = new SqlParameter("@Type", obj.UserID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Users", prm);

        }
        public static BL_Users CheckLogin(string UserName,string Password)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@UserName", UserName);
            prm[1] = new SqlParameter("@Password", Password);
            prm[2] = new SqlParameter("@Type", 4);
            DataTable dt= DataAccess.GetDataTable("SP_Users", prm);
            BL_Users obj = new BL_Users();
            if (dt.Rows.Count>0)
            {
                obj.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                obj.FirstName = dt.Rows[0]["First_Name"].ToString();
                obj.LastName = dt.Rows[0]["Last_Name"].ToString();
                obj.Contact = dt.Rows[0]["Contact"].ToString();
                obj.Email = dt.Rows[0]["Email"].ToString();
                obj.Gender = dt.Rows[0]["Gender"].ToString();
                obj.UserName = dt.Rows[0]["UserName"].ToString();
                obj.Password = dt.Rows[0]["Password"].ToString();
                obj.AccountType = dt.Rows[0]["Acount_Type"].ToString();
                obj.Status = dt.Rows[0]["Acount_Status"].ToString();
                obj.IsAdmin= Convert.ToBoolean(dt.Rows[0]["IsAdmin"]);
            }
            return obj;
        }
        public static DataTable CheckUsername(string UserName)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@UserName", UserName);
            prm[1] = new SqlParameter("@Type", 5);
            return DataAccess.GetDataTable("SP_Users", prm);
        }
        public static void ChangePassword(int ID,String UserName,String Password)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@UserID", ID);
            prm[1] = new SqlParameter("@UserName", UserName);
            prm[2] = new SqlParameter("@Password", Password);
            prm[3] = new SqlParameter("@Type", 6);
            DataAccess.Sp_ExecuteQuery("SP_Users", prm);
        }
    }
}
