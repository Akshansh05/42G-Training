using Crud_Api_PartB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace Crud_Api_PartB
{
    public class BusinessModel
    {
        public string show()
        {
            String result = "";
            Connection conn = new Connection();

            StringBuilder sb_View = new StringBuilder();
            sb_View.Append("Select * from Intern;");//Viewing the data
            String sql = sb_View.ToString();
            List<Intern> intern_list = new List<Intern>();
            using (SqlCommand command = new SqlCommand(sql, conn.con()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Intern intern = new Intern();
                        intern.id = (int)reader.GetValue(0);
                        intern.name = reader.GetValue(1).ToString();
                        intern_list.Add(intern);
                    }
                }

                result = Newtonsoft.Json.JsonConvert.SerializeObject(intern_list);
            }

            return result;
        }
        public Intern Insert(Intern intern)
        {
            Connection conn = new Connection();
            string sqlText = "Insert into Intern values(@Id,@name)";
            SqlCommand sqlCmd = new SqlCommand(sqlText, conn.con());
            sqlCmd.Parameters.AddWithValue("@Id", intern.id);
            sqlCmd.Parameters.AddWithValue("@name", intern.name);

            int i = sqlCmd.ExecuteNonQuery();
            return intern;
        }
        public Intern Update(Intern intern,int id)
        {
            Connection conn = new Connection();
            string sqlText = "Update Intern set Id=@Id,Name=@name where Id=" + id + ";";
            SqlCommand sqlCmd = new SqlCommand(sqlText, conn.con());
            sqlCmd.Parameters.AddWithValue("@Id", intern.id);
            sqlCmd.Parameters.AddWithValue("@name", intern.name);
            sqlCmd.ExecuteNonQuery();
            return intern;
        }
        public String Delete(Intern intern, int id)
        {
            Connection conn = new Connection();
            string sqlText = "Delete from Intern  where Id=" + id + ";";
            SqlCommand sqlCmd = new SqlCommand(sqlText, conn.con());
            sqlCmd.ExecuteNonQuery();
            return "Deleted Successfully";
        }

    }
}