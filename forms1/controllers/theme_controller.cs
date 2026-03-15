using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forms1.models;

namespace forms1.controllers
{
    public class Theme_controller
    {
        private MySqlConnection conn;
        private Theme_model theme_model;

        public Theme_controller(MySqlConnection Conn)
        {
            conn = Conn;
            theme_model = new Theme_model(conn);
        }

        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public Theme_model Theme_model
        { get { return theme_model; } set { theme_model = value; } }

        public List<string> get_all_theme()
        {
            List<string> themes = theme_model.get_all_theme();
            if (themes.Count > 0)
            {
                return themes;
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
