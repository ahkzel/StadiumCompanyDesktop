using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Answer_model
    {
        private MySqlConnection conn;

        public Answer_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public List<string> get_all_answers()
        {
            string query = "SELECT valeur FROM reponses";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    List<string> answers = new List<string>();
                    int colLabel = reader.GetOrdinal("valeur");
                    while (reader.Read())
                    {
                        string answer = reader.GetString(colLabel);
                        answers.Add(answer);
                    }
                    return answers;
                }
            }
        }

        public List<string> get_answer_from_question(int id_question)
        {
            string query = "SELECT valeur FROM reponses INNER JOIN verifie ON verifie.id_reponse = reponses.id " +
                "INNER JOIN question ON question.id = verifie.id_question WHERE question.id = @id_question";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_question", id_question);
                using (var reader = cmd.ExecuteReader())
                {
                    List<string> answers = new List<string>();
                    int colLabel = reader.GetOrdinal("valeur");
                    while (reader.Read())
                    {
                        string answer = reader.GetString(colLabel);
                        answers.Add(answer);
                    }
                    return answers;
                }
            }
        }

        public int get_id_from_name(string name_answer)
        {
            string query = "SELECT id FROM reponses WHERE valeur = @name_answer";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name_answer", name_answer);
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
