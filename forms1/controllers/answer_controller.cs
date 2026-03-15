using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forms1.models;

namespace forms1.controllers
{
    public class Answer_controller
    {
        private MySqlConnection conn;
        private Answer_model answer_model;
        private Question_model question_model;
        private Verifie_model verifie_model;

        public Answer_controller(MySqlConnection Conn)
        {
            conn = Conn;
            answer_model = new Answer_model(conn);
            question_model = new Question_model(conn);
            verifie_model = new Verifie_model(conn);
        }

        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public Answer_model Answer_model
        { get { return answer_model; } set { answer_model = value; } }
        public Question_model Question_model
        { get { return question_model; } set { question_model = value; } }
        public Verifie_model Verifie_model
        { get { return verifie_model; } set { verifie_model = value; } }

        public List<string> get_answer_from_question_quizz(string name_question, int id_quizz)
        {
            int question_id = question_model.get_id_from_name_and_quizz(name_question, id_quizz);
            return answer_model.get_answer_from_question(question_id);
        }

        public List<string> get_answer_not_from_question(string name_question, int id_quizz)
        {
            List<string> all_answers = answer_model.get_all_answers();
            List<string> answers_from_question = get_answer_from_question_quizz(name_question, id_quizz);
            List<string> ret = new List<string>();
            foreach (string answer in all_answers)
            {
                if (!answers_from_question.Contains(answer))
                {
                    ret.Add(answer);
                }
            }
            return ret;
        }

        public List<string> get_all_answers()
        {
            return answer_model.get_all_answers();
        }

        public void delete_answers_from_question_quizz(string name_question, int id_quizz)
        {
            int question_id = question_model.get_id_from_name_and_quizz(name_question, id_quizz);
            verifie_model.delete_verifie_from_question_quizz(question_id, id_quizz);
        }

        public void add_answers_to_question_quizz(string name_question, int id_quizz, List<string> answers, string right_answer, int weight)
        {
            int question_id = question_model.get_id_from_name_and_quizz(name_question, id_quizz);
            int num_reponse = 0;
            foreach (string answer in answers)
            {
                int answer_id = answer_model.get_id_from_name(answer);
                int is_correct = (answer == right_answer) ? 1 : 0;
                verifie_model.add_verifie_from_question_id(question_id, answer_id, is_correct, num_reponse, weight);
                num_reponse++;
            }
        }
    }
}
