using System;
using MySql.Data;
using MySql.Data.MySqlClient;
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
            server = "localhost";
            db_name = "";
            uid = "root";
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
                if (String.IsNullOrEmpty(Db_name))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3};", Server, Db_name, Uid, Password);
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
