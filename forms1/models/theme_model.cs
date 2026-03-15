using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Theme_model
    {
        private MySqlConnection conn;

        public Theme_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public string get_theme_from_id(int id_theme)
        {
            string query = "SELECT nom FROM theme WHERE id = @id_theme";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_theme", id_theme);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString("nom");
                    }
                }
            }
            return "";
        }

        public string get_theme_from_quizz(string name_quizz)
        {
            string query = "SELECT theme.nom FROM theme INNER JOIN questionnaire on questionnaire.id_theme = theme.id WHERE " +
                "questionnaire.nom = @name_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name_quizz", name_quizz);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString("nom");
                    }
                }
            }
            return "";
        }

        public List<string> get_all_theme()
        {
            string query = "SELECT nom FROM theme";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    List<string> themes = new List<string>();
                    int colNom = reader.GetOrdinal("nom");
                    while (reader.Read())
                    {
                        themes.Add(reader.GetString(colNom));
                    }
                    return themes;
                }
            }
        }

        public int get_id_from_name(string name_theme)
        {
            string query = "SELECT id FROM theme WHERE nom = @name_theme";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name_theme", name_theme);
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
