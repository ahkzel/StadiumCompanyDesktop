using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
namespace forms1.models
{
    public class User_model
    {
        private MySqlConnection conn;

        public User_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public List<string> get_user(string email, string password)
        {
            string query = "SELECT first_name, name, email FROM user WHERE email = @email AND password = @password";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    List<string> the_client = new List<string>();
                    while (reader.Read())
                    {
                        the_client.Add(reader.GetString("first_name"));
                        the_client.Add(reader.GetString("name"));
                        the_client.Add(reader.GetString("email"));
                    }

                    reader.Close();
                    return the_client;
                }
            }
        }

        public int add_user(string first_name, string name, string email, string password)
        {
            string query = @"insert into user (first_name, name, email, password) 
            VALUES (@first_name, @name, @email, @password)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                int ret = cmd.ExecuteNonQuery();
                return ret;
            }
        }

        public int get_id_from_email(string email)
        {
            string query = "SELECT id FROM user WHERE email = @email";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("id");
                    }
                }
            }
            return -1;
        }
    }
}
