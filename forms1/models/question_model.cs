using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms1.models
{
    public class Question_model
    {
        private MySqlConnection conn;

        public Question_model(MySqlConnection Conn)
        {
            conn = Conn;
        }

        public List<List<string>> get_all_questions_from_quizz(int id_quizz)
        {
            string query = "SELECT question.label, question.id_type FROM question INNER JOIN comporte " +
                "on question.id = comporte.id_question INNER JOIN questionnaire ON questionnaire.id = comporte.id_questionnaire" +
                " WHERE questionnaire.id = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                using (var reader = cmd.ExecuteReader())
                {
                    List<List<string>> questions = new List<List<string>>();
                    int colLabel = reader.GetOrdinal("label");
                    int colId = reader.GetOrdinal("id_type");
                    while (reader.Read())
                    {
                        List<string> question = new List<string> {
                            reader.GetString(colLabel),
                            reader.GetInt32(colId).ToString() };
                        questions.Add(question);
                    }
                    return questions;
                }
            }
        }

        public List<List<string>> get_all_questions()
        {
            string query = "SELECT label, id_type FROM question";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    List<List<string>> questions = new List<List<string>>();
                    int colLabel = reader.GetOrdinal("label");
                    int colId = reader.GetOrdinal("id_type");
                    while (reader.Read())
                    {
                        List<string> quizz = new List<string> {
                            reader.GetString(colLabel),
                            reader.GetInt32(colId).ToString() };
                        questions.Add(quizz);
                    }
                    return questions;
                }
            }
        }

        public List<string> get_question_from_name(string name)
        {
            string query = "SELECT label, id_type FROM question WHERE label = @name";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                using (var reader = cmd.ExecuteReader())
                {
                    List<string> question = new List<string>();
                    int colLabel = reader.GetOrdinal("label");
                    int colId = reader.GetOrdinal("id_type");
                    if (reader.Read())
                    {
                        question.Add(reader.GetString(colLabel));
                        question.Add(reader.GetInt32(colId).ToString());
                    }
                    return question;
                }
            }
        }

        public int get_id_from_name(string name)
        {
            string query = "SELECT id FROM question WHERE label = @name";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                using (var reader = cmd.ExecuteReader())
                {
                    int colId = reader.GetOrdinal("id");
                    if (reader.Read())
                    {
                        return reader.GetInt32(colId);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public int get_id_from_name_and_quizz(string name, int id_quizz)
        {
            string query = "SELECT question.id FROM question INNER JOIN comporte on question.id = comporte.id_question " +
                "INNER JOIN questionnaire ON questionnaire.id = comporte.id_questionnaire WHERE question.label = @name AND " +
                "questionnaire.id = @id_quizz";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                using (var reader = cmd.ExecuteReader())
                {
                    int colId = reader.GetOrdinal("id");
                    if (reader.Read())
                    {
                        return reader.GetInt32(colId);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public int get_type_from_question(int id_question)
        {
            string query = "SELECT id_type FROM question WHERE id = @id_question";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id_question", id_question);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }

        public void update_question_from_name_and_quizz(string name, int id_quizz, int id_type, int id_question)
        {
            string query = "UPDATE question INNER JOIN comporte on question.id = comporte.id_question " +
                "INNER JOIN questionnaire ON questionnaire.id = comporte.id_questionnaire SET question.label = @name, question.id_type = @id_type " +
                "WHERE questionnaire.id = @id_quizz AND question.id = @id_question";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id_type", id_type);
                cmd.Parameters.AddWithValue("@id_quizz", id_quizz);
                cmd.Parameters.AddWithValue("@id_question", id_question);
                cmd.ExecuteNonQuery();
            }
        }

        public int create_question_from_name_and_quizz(string name, int id_quizz, int id_type)
        {
            string query = "INSERT INTO question (label, id_type) VALUES (@name, @id_type)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id_type", id_type);
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.LastInsertedId);
            }
        }
    }
}
 