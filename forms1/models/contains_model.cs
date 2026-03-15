using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Contains_model
    {
        private MySqlConnection conn;

        public Contains_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public int get_question_number_from_quizz(string name_quizz)
        {
            int count = 0;
            string query = "SELECT COUNT(id_question) FROM comporte INNER JOIN questionnaire ON " +
                "questionnaire.id = comporte.id_questionnaire WHERE questionnaire.nom = @name_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name_quizz", name_quizz);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }

        public int get_question_index_from_quizz_question(int id_quizz, string label_question)
        {
            int index = 0;
            string query = "SELECT num_question FROM comporte INNER JOIN questionnaire ON questionnaire.id = comporte.id_questionnaire " +
                "INNER JOIN question on question.id = comporte.id_question where questionnaire.id = @id_quizz AND " +
                "question.label = @label_question";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.Parameters.AddWithValue("@label_question", label_question);
                index = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return index;
        }

        public void add_question_to_quizz(int id_question, int id_quizz, int num_question)
        {
            string query = "INSERT INTO comporte (id_question, id_questionnaire, num_question) VALUES " +
                "(@id_question, @id_quizz, @num_question)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_question", id_question);
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.Parameters.AddWithValue("@num_question", num_question);
                cmd.ExecuteNonQuery();
            }
        }

        public int get_last_num_question_from_quizz(int id_quizz)
        {
            int num_question = 0;
            string query = "SELECT MAX(num_question) FROM comporte WHERE id_questionnaire = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    num_question = Convert.ToInt32(result);
                }
            }
            return num_question;

        }

        public void delete_question_from_quizz(int id_question, int id_quizz)
        {
            string query = "DELETE FROM comporte WHERE id_question = @id_question AND id_questionnaire = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_question", id_question);
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.ExecuteNonQuery();
            }
        }

        public void update_num_question_from_quizz(int id_quizz)
        {
            string query = "UPDATE comporte JOIN (SELECT id_question, ROW_NUMBER() OVER (ORDER BY num_question) AS rn FROM comporte WHERE " +
                "id_questionnaire = @id_quizz) t USING (id_question) SET comporte.num_question = t.rn WHERE " +
                "comporte.id_questionnaire = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
