using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
namespace connection_db
{
    public class DBConnection
    {
        private string server;
        private string db_name;
        private string uid;
        private string password;

        public DBConnection()
        {
            server = "";
            db_name = "";
            uid = "";
            password = "";
        }

        public string Server
        { get { return server; } set { server = value; } }
        public string Db_name
        { get { return db_name; } set { db_name = value; } }
        public string Uid
        { get { return uid; } set { uid = value; } }
        public string Password
        { get { return password; } set { password = value; } }

        public MySqlConnection Connection { get; set; }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

                string connstring = string.Format("Server={0}; Port={1}; database={2}; UID={3}; password={4};", config["Database:Server"], config["Database:Port"], config["Database:DbName"], config["Database:Uid"], config["Database:Password"]);
                Connection = new MySqlConnection(connstring);
                Connection.Open();
            }

            return true;
        }


        public void Close()
        {
            Connection.Close();
        }
    }
}
