using forms1.models;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
namespace forms1.controllers
{
    public class User_controller
    {
        private MySqlConnection conn;
        private User_model user_model;

        public User_controller(MySqlConnection Conn)
        {
            conn = Conn;
            user_model = new User_model(conn);
        }
        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public User_model User_model
        { get { return user_model; } set { user_model = value; } }

        public string add_user(string first_name, string name, string email, string password)
        {
            string hashed_password = this.string_to_hash(password);
            List<string> existing_user = user_model.get_user(email, hashed_password);
            if (existing_user.Count > 0)
            {
                return "An account with this email already exists";
            }

            int has_worked = user_model.add_user(first_name, name, email, hashed_password);
            if (has_worked > 0)
            {
                return "Your account was successfully created";
            }
            else
            {
                return "a problem occured in the processus of creation of your account";
            }
        }

        public List<string> get_user(string email, string password)
        {
            string hashed_password = this.string_to_hash(password);
            List<string> user = user_model.get_user(email, hashed_password);
            if (user.Count > 0)
            {
                return user;
            }
            else
            {
                return new List<string>();
            }
        }

        public string string_to_hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
