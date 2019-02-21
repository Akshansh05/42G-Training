using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_pageExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* try
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                builder.DataSource = "AKSHANSH-IN08";
                builder.UserID = "Akshansh";
                builder.Password = "12345678";
                builder.InitialCatalog = "master";
               // Console.Write("conneting to db");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    //Console.WriteLine();
                   // Console.WriteLine("done");
                    //Console.WriteLine();
                   // Console.Write("Creating the Database SampleDb");
                    string sql = "DROP DATABASE IF EXISTS [SampleDB]; CREATE DATABASE [SampleDB]";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        //Console.WriteLine();
                       // Console.WriteLine("Done creating Database");
                    }
                    //Console.WriteLine();
                   // Console.Write("Creating sample table with data, press any key to continue...");
                   // Console.ReadKey(true);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("USE SampleDB; ");
                    sb.Append("CREATE TABLE Employee(NAME varchar(500),PASSWORD varchar(500));");//creating table
                    sb.Append("INSERT INTO Employee values ");
                    sb.Append("('Akshansh','1234'),");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                       // Console.WriteLine();
                       // Console.WriteLine("Done creating Table and Inserting Values");

                    }
                           connection.Close();
                        }
                    }
                    catch (Exception Exp)
                    {
                        Console.WriteLine(Exp.ToString());
                    }
                    Console.ReadKey();*/

                }

        protected void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                builder.DataSource = "AKSHANSH-IN08";
                builder.UserID = "Akshansh";
                builder.Password = "12345678";
                builder.InitialCatalog = "master";
                // Console.Write("conneting to db");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = "select * from Employee where NAME='@name' and PASSWORD='@pass';";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", usename.Text);
                        command.Parameters.AddWithValue("@pass", password.Text);
                        //command.ExecuteNonQuery();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Response.Redirect("WebForm2.aspx");
                            }
                        }

                    }
                }
            }
            catch (Exception Exp)
            {
                Console.WriteLine(Exp.ToString());
            }
            //Console.ReadKey();


            if (usename.Text == "" || password.Text == "")
            {
                Response.Write("<script>alert('Invalid')</script>");
            }
           /* else if (usename.Text == "Akshansh" && password.Text == "1234")
            {
                Session["user"] = usename.Text;
                 HttpCookie userInfo = new HttpCookie("userInfo");
                userInfo["name"] = usename.Text;
                userInfo["pass"] = password.Text;
                userInfo.Expires.Add(new TimeSpan(0, 0, 30));
                Response.Redirect("WebForm2.aspx");
                Response.Write("<script>alert('cookie created')</script>");

            }*/
            else
            {
                Response.Write("<script>alert('Wrong Id')</script>");
            }
        }
    }
}