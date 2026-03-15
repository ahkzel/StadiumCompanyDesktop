using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Verifie_model
    {
        private MySqlConnection conn;

        public Verifie_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public void delete_verifie_from_question_quizz(int id_question, int id_quizz)
        {
            string query = "DELETE verifie FROM verifie INNER JOIN reponses ON verifie.id_reponse = reponses.id INNER JOIN " +
                "question ON verifie.id_question = question.id INNER JOIN comporte ON question.id = comporte.id_question " +
                "INNER JOIN questionnaire ON questionnaire.id = comporte.id_questionnaire WHERE question.id = @id_question " +
                "AND questionnaire.id = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_question", id_question);
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.ExecuteNonQuery();
            }
        }

        public void add_verifie_from_question_id(int question_id, int answer_id, int is_correct, int num_reponse, int weight)
        {
            string query = "INSERT INTO verifie (id_question, id_reponse, veracite, num_reponse, poids) VALUES (@id_question, @id_reponse, @veracite, @num_reponse, @poids)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_question", question_id);
                cmd.Parameters.AddWithValue("@id_reponse", answer_id);
                cmd.Parameters.AddWithValue("@veracite", is_correct);
                cmd.Parameters.AddWithValue("@num_reponse", num_reponse);
                cmd.Parameters.AddWithValue("@poids", weight);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
