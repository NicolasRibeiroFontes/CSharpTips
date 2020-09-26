using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace CSharp_Tips.SOLID.SingleResponsabilityPrinciple.Problem
{
    public class Problem
    {

    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }

    public class UserService
    {
        private readonly string connectionString = "";

        public bool SaveUser(User user)
        {
            if (user.Name == "" || user.Email == "" || !user.Email.Contains("@"))
                return false;

            string sql = "INSERT INTO [User](Name, Email) VALUES(@name, @email)";

            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                connection.Open();

                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
            return true;
        }
    }
}
