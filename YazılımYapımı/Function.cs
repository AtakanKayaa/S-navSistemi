using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;





namespace YazılımYapımı
{
    internal class Function
    {

        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=DESKTOP-O20Q3K8\\SQLEXPRESS;Initial Catalog=SinavSistemi;Integrated Security=True";

            return con;
        }

        public DataSet GetData(string query)
        {
            SqlConnection con = GetConnection(); SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds;

        }
        public void setData(string query, string msg)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public SqlDataReader getForCombo(string query)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;




        }


    }



}
