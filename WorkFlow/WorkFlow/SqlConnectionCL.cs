using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WorkFlow
{
    class SqlConnectionCL
    {
        string connetionString = "Data Source=DESKTOP-P3V6QMJ;Initial Catalog=Teklas_Calisan_Work;Integrated Security=True";
        SqlConnection cnn;

        public List<string> GetQuery(string query, string qColumn)
        {
            cnn = new SqlConnection(connetionString);
            List<string> returnQry = new List<string>();
            SqlCommand command = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    returnQry.Add(reader[qColumn].ToString());
                }
                return returnQry;
            }
            finally
            {
                reader.Close();
                cnn.Close();
            }
        }

        public DataSet BindGrid(string query)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }

        public void InsertToTables(string qy)
        {
            cnn = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand(qy, cnn);
            cnn.Open();
            command.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
