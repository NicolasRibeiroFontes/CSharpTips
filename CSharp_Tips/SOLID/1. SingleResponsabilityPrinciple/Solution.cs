using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CSharp_Tips.SOLID.SingleResponsabilityPrinciple.Solution
{
    public class Solution
    {

    }

    public class ConnectionRepository
    {
        SqlConnection connection = new SqlConnection("Connection String");

        public SqlConnection OpenConnection()
        {
            connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }

    public class User
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class UserRepository
    {
        public void SaveUser(User user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO User(Name, Email) VALUES(@name, @email)";
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.ExecuteNonQuery();
            }                
        }
    }

    public class UserService
    {
        ConnectionRepository connection = new ConnectionRepository();
        UserRepository userRepository = new UserRepository();

        public bool SaveUser(User user)
        {
            if (!ValidUser(user))
                return false;

            connection.OpenConnection();

            userRepository.SaveUser(user);

            connection.CloseConnection();

            return true;
        }

        private bool ValidUser(User user)
        {
            if (user.Name == "" || user.Email == "" || !user.Email.Contains("@"))
                return false;

            return true;
        }
    }
}
