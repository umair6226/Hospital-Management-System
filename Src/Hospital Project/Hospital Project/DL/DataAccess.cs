using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project.DL
{
    class DataAccess
    {
        static SqlConnection Conn = new SqlConnection(@" data source=DESKTOP-K2GSK27; initial catalog=Hospital; integrated security=true");


        public static void Sp_ExecuteQuery(string sp_Name, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp_Name;
            cmd.Parameters.AddRange(prm);
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
      
        public static DataTable GetDataTable(string sp_Name, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand(sp_Name, Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp_Name;
            cmd.Parameters.AddRange(prm);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public static SqlDataReader ExecuteDataSet(string query, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(prm);
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //return ds;

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader;
           

        } 

    }
}
