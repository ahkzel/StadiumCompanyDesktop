using connection_db;
using forms1.controllers;
using MySql.Data.MySqlClient;
using System;
namespace forms1
{
    public class Init
    {
        private DBConnection db_con;
        private MySqlConnection conn;
        private Main_controller main_controller;

        public Init()
        {
            db_con = new DBConnection();
            db_con.Password = "FrouFrou";
            db_con.Db_name = "ppe";
            db_con.IsConnect();
            conn = db_con.Connection;
            main_controller = new Main_controller(conn);
        }

        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public DBConnection Db_con
        { get { return db_con; } set { db_con = value; } }
        public Main_controller Main_controller
        { get { return main_controller; } set { main_controller = value; } }
    }
}
