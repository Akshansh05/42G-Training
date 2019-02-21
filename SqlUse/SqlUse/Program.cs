using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlUse
{
    class Program
    {public static void show(SqlConnection connection)
        {
            StringBuilder sb_View = new StringBuilder();
            sb_View.Append("Select * from Employee;");//Viewing the data
           String sql = sb_View.ToString();
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0},{1},{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Done Displaying Table");

            }
        }
        static void Main(string[] args)
        {
            try
            {
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                builder.DataSource = "AKSHANSH-IN08";
                builder.UserID = "Akshansh";
                builder.Password = "12345678";
                builder.InitialCatalog = "master";
                Console.Write("conneting to db");
                using(SqlConnection connection=new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine();
                    Console.WriteLine("done");
                    Console.WriteLine();
                    Console.Write("Creating the Database SampleDb");
                    string sql= "DROP DATABASE IF EXISTS [SampleDB]; CREATE DATABASE [SampleDB]";
                    using(SqlCommand command=new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine();
                        Console.WriteLine("Done creating Database");
                    }
                    Console.WriteLine();
                    Console.Write("Creating sample table with data, press any key to continue...");
                    Console.ReadKey(true);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("USE SampleDB; ");
                    sb.Append("CREATE TABLE Employee(ID int primary key not null,NAME varchar(500),COUNTRY varchar(500));");//creating table
                    sb.Append("INSERT INTO Employee values ");//insert data
                    sb.Append("(1,'Abhay','India'),");
                    sb.Append("(2,'Aman','India'),");
                    sb.Append("(3,'Jack','USA');");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        command.ExecuteNonQuery();
                        Console.WriteLine();
                        Console.WriteLine("Done creating Table and Inserting Values");
                       
                    }
                    show(connection);
                    Console.Write("Inserting a new row into table, press any key to continue...");
                    Console.ReadKey(true);
                    Console.WriteLine();
                    Console.WriteLine("Enter id");
                    int id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Country");
                    string country = Console.ReadLine();
                    sb.Clear();
                    sb.Append("INSERT Employee ");
                    sb.Append("VALUES (@id,@name, @location);");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@location", country);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine();
                        Console.WriteLine(rowsAffected + " row(s) inserted");
                        Console.WriteLine();
                    }
                    show(connection);
                    
                    Console.Write("Updating 'Country' for user , press any key to continue...");
                    Console.ReadKey(true);
                    Console.WriteLine();
                    Console.WriteLine("Enter the name");
                    string userToUpdate = Console.ReadLine();
                    Console.WriteLine("Enter the Country");
                    string userToUpdate_Country = Console.ReadLine();
                    sb.Clear();
                    sb.Append("UPDATE Employee SET COUNTRY = @country WHERE NAME = @name");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@country", userToUpdate_Country);
                        command.Parameters.AddWithValue("@name", userToUpdate);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                        Console.WriteLine();
                    }
                    show(connection);
                    Console.Write("Deleting user , press any key to continue...");
                    Console.ReadKey(true);
                    Console.WriteLine();
                    Console.WriteLine("Enter the name");
                    string userToDelete = Console.ReadLine();
                    sb.Clear();
                    sb.Append("DELETE from Employee WHERE NAME = @name");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", userToUpdate);
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine(rowsAffected + " row(s) updated");
                        Console.WriteLine();
                    }
                    show(connection);

                    connection.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
