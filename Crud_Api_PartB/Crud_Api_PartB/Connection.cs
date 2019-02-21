using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Crud_Api_PartB
{
    public class Connection
    {
        public SqlConnection con()
        {
            SqlConnection connection = null;
            try
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                builder.DataSource = "AKSHANSH-IN08";
                builder.UserID = "Akshansh";
                builder.Password = "12345678";
                builder.InitialCatalog = "SampleDB";
                connection = new SqlConnection(builder.ConnectionString);
                // Console.Write("conneting to db");
                //using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                //{ 
                connection.Open();
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return connection;
        }
    }
}