using forms1.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace forms1.controllers
{
    public class Question_controller
    {
        private MySqlConnection conn;
        private Question_model question_model;
        private Contains_model contains_model;
        private Type_model type_model;

        public Question_controller(MySqlConnection Conn)
        {
            conn = Conn;
            question_model = new Question_model(conn);
            contains_model = new Contains_model(conn);
            type_model = new Type_model(conn);
        }

        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }

        public Question_model Question_model
        { get { return question_model; } set { question_model = value; } }
        public Contains_model Contains_model
        { get { return contains_model; } set { contains_model = value; } }
        public Type_model Type_model
        { get { return type_model; } set { type_model = value; } }

        public List<List<string>> get_all_questions_from_quizz(int id_quizz)
        {
            List<List<string>> base_questions = question_model.get_all_questions_from_quizz(id_quizz);
            List<List<string>> ret = new List<List<string>>();
            foreach (List<string> question in base_questions)
            {
                string type_name = type_model.get_type_from_id(int.Parse(question[1]));
                int num_question = contains_model.get_question_index_from_quizz_question(id_quizz, question[0]);
                ret.Add(new List<string> { num_question.ToString(), question[0], type_name });
            }
            return ret;
        }

        public List<string> get_all_questions_name()
        {
            List<List<string>> all_questions = question_model.get_all_questions();
            List<string> ret = new List<string>();
            foreach (List<string> question in all_questions)
            {
                ret.Add(question[0]);
            }
            return ret;
        }

        public List<string> get_question_from_name(string name, int id_quizz)
        {
            List<string> question = question_model.get_question_from_name(name);
            string type_name = type_model.get_type_from_id(int.Parse(question[1]));
            string num_question = (contains_model.get_last_num_question_from_quizz(id_quizz) + 1).ToString();
            return new List<string> { num_question, question[0], type_name };
        }

        public List<string> get_questions_not_from_quizz(int id_quizz)
        {
            List<List<string>> all_questions = question_model.get_all_questions();
            List<List<string>> questions_from_quizz = question_model.get_all_questions_from_quizz(id_quizz);
            List<string> ret = new List<string>();
            foreach (List<string> question in all_questions)
            {
                bool found = false;
                foreach (List<string> question_from_quizz in questions_from_quizz)
                {
                    if (question[0] == question_from_quizz[0])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    ret.Add(question[0]);
                }
            }
            return ret;
        }

        public void update_question_from_name_and_quizz(string old_name_question, string name_question, int id_quizz, string type_question)
        {
            int type_id = type_model.get_id_from_type(type_question);
            int question_id = question_model.get_id_from_name_and_quizz(old_name_question, id_quizz);
            question_model.update_question_from_name_and_quizz(name_question, id_quizz, type_id, question_id);
        }

        public void create_question_from_name_and_quizz(string name_question, int id_quizz, string type_question)
        {
            int type_id = type_model.get_id_from_type(type_question);
            int id_question = question_model.create_question_from_name_and_quizz(name_question, id_quizz, type_id);
            int num_question = contains_model.get_last_num_question_from_quizz(id_quizz) + 1;
            contains_model.add_question_to_quizz(id_question, id_quizz, num_question);
        }

        public void delete_question_from_name_and_quizz(string name_question, int id_quizz)
        {
            int id_question = question_model.get_id_from_name_and_quizz(name_question, id_quizz);
            contains_model.delete_question_from_quizz(id_question, id_quizz);
            contains_model.update_num_question_from_quizz(id_quizz);
        }

        public string get_type_from_question_quizz(string name_question, int id_quizz)
        {
            int question_id = question_model.get_id_from_name_and_quizz(name_question, id_quizz);
            int type_id = question_model.get_type_from_question(question_id);
            return type_model.get_type_from_id(type_id);
        }
    }
}
