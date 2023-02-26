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
    class BL_Pharmacy
    {
        public int ProductID { get; set; }
        public string ProName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Avalaibility { get; set; }
        public int Type { get; set; }

        public void Save(BL_Pharmacy obj)
        {
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter("@ProductID",obj.ProductID );
            prm[1] = new SqlParameter("@Name", obj.ProName);
            prm[2] = new SqlParameter("@Category",obj.Category );
            prm[3] = new SqlParameter("@Quantity",obj.Quantity );
            prm[4] = new SqlParameter("@Price",obj.Price );
            prm[5] = new SqlParameter("@ExpiryDate",obj.ExpiryDate );
            prm[6] = new SqlParameter("@Avalaiblity", obj.Avalaibility );
            prm[7] = new SqlParameter("@Type", obj.ProductID == 0 ? 1 : 2);
            DataAccess.Sp_ExecuteQuery("SP_Parmacy", prm);
        }
        public DataTable LoadData(BL_Pharmacy obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4);
            return DataAccess.GetDataTable("SP_Parmacy", prm);
        }
        public DataTable ExpiredMedic(BL_Pharmacy obj)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 7);
            return DataAccess.GetDataTable("SP_Parmacy", prm);
        }
        public DataTable SearchData(BL_Pharmacy obj)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@Name", obj.ProName);
            prm[1] = new SqlParameter("@Category", obj.Category);
            prm[2] = new SqlParameter("@Type", obj.Type);
            return DataAccess.GetDataTable("SP_Parmacy", prm);
        }
        public DataTable CheckAvalaible(BL_Pharmacy obj)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Quantity", obj.Quantity);
            prm[1] = new SqlParameter("@Type", 1);
            return DataAccess.GetDataTable("SP_Avalaibility", prm);
        }
    }
}
