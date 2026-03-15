using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Quizz_model
    {
        private MySqlConnection conn;

        public Quizz_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public List<string> get_quizz(string name)
        {
            string query = "SELECT nom, id_theme FROM questionnaire WHERE nom = @name";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                using (var reader = cmd.ExecuteReader())
                {
                    List<string> quizz = new List<string>();
                    if (reader.Read())
                    {
                        int colNom = reader.GetOrdinal("nom");
                        int colId = reader.GetOrdinal("id_theme");
                        quizz.Add(reader.GetString(colNom));
                        quizz.Add(reader.GetInt32(colId).ToString());
                    }
                    return quizz;
                }
            }
        }

        public List<List<string>> get_all_quizz()
        {
            string query = "SELECT nom, id_theme FROM questionnaire";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    List<List<string>> quizzs = new List<List<string>>();
                    int colNom = reader.GetOrdinal("nom");
                    int colId = reader.GetOrdinal("id_theme");
                    while (reader.Read())
                    {
                        List<string> quizz = new List<string> {
                            reader.GetString(colNom),
                            reader.GetInt32(colId).ToString() };
                        quizzs.Add(quizz);
                    }
                    return quizzs;
                }
            }
        }

        public int get_id_from_name(string name)
        {
            string query = "SELECT id FROM questionnaire WHERE nom = @name";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colId = reader.GetOrdinal("id");
                        return reader.GetInt32(colId);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public void delete_quizz(string name)
        {
            string query = "DELETE FROM questionnaire WHERE nom = @name";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        public void create_quizz_without_question(string name, int id_user, int id_theme)
        {
            string query = "INSERT INTO questionnaire (nom, publie, id_user, id_theme) VALUES (@name, 1, @id_user, @id_theme)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id_user", id_user);
                cmd.Parameters.AddWithValue("@id_theme", id_theme);
                cmd.ExecuteNonQuery();
            }
        }

        public int get_id_quizz_from_name(string name)
        {
            string query = "SELECT id FROM questionnaire WHERE nom = @name";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colId = reader.GetOrdinal("id");
                        return reader.GetInt32(colId);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public int get_latest_quizz_id()
        {
            string query = "SELECT id FROM questionnaire ORDER BY id DESC LIMIT 1";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colId = reader.GetOrdinal("id");
                        return reader.GetInt32(colId);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public int get_theme_id_from_quizz_id(int id_quizz)
        {
            string query = "SELECT id_theme FROM questionnaire WHERE questionnaire.id = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colId = reader.GetOrdinal("id_theme");
                        return reader.GetInt32(colId);
                    }
                }
            }
            return -1;
        }

        public void update_quizz_from_id(string name_quizz, int id_theme, int id_quizz)
        {
            string query = "UPDATE questionnaire SET nom = @name_quizz, id_theme = @id_theme WHERE id = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name_quizz", name_quizz);
                cmd.Parameters.AddWithValue("@id_theme", id_theme);
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
