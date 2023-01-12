using Dapper;
using MySql.Data.MySqlClient;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Ramsey_Stair_CRUD_Project.Service
{
    public class UserDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Test; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //private readonly IDbConnection _conn;
        //public UserDAO(IDbConnection conn)
        //{
        //    _conn = conn;
        //}

        public bool FindUserByNameAndPassword(User user)
        {
            bool success = false;
            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username AND password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return success;
            
            //bool success = false;  
            
            //var users = _conn.Query<User>("SELECT * FROM user;").ToList();
            //foreach(var use in users)
            //{
            //    if(use.UserName == user.UserName && use.Password == user.Password)
            //    {
            //        success = true;
            //    }
            //}
            //return success;
            
        }

        public UserDAO()
        {

        }
    }
}
