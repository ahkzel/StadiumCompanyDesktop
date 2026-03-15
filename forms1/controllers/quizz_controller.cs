using forms1.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace forms1.controllers
{
    public class Quizz_controller
    {
        private MySqlConnection conn;
        private Quizz_model quizz_model;
        private Contains_model contains_model;
        private Theme_model theme_model;
        private User_model user_model;
        private Question_model question_model;

        public Quizz_controller(MySqlConnection Conn)
        {
            conn = Conn;
            quizz_model = new Quizz_model(conn);
            contains_model = new Contains_model(conn);
            theme_model = new Theme_model(conn);
            user_model = new User_model(conn);
            question_model = new Question_model(conn);
        }
        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public Quizz_model Quizz_model
        { get { return quizz_model; } set { quizz_model = value; } }
        public Contains_model Contains_model
        { get { return contains_model; } set { contains_model = value; } }
        public Theme_model Theme_model
        { get { return theme_model; } set { theme_model = value; } }
        public User_model User_model
        { get { return user_model; } set { user_model = value; } }
        public Question_model Question_model
        { get { return question_model; } set { question_model = value; } }


        public List<string> get_quizz(string name)
        {
            List<string> quizz = quizz_model.get_quizz(name);
            if (quizz.Count > 0)
            {
                int nb_questions = contains_model.get_question_number_from_quizz(name);
                string theme_name = theme_model.get_theme_from_id(int.Parse(quizz[1]));
                List<string> ret = new List<string> { quizz[0], nb_questions.ToString(), theme_name };
                return ret;
            }
            else
            {
                return new List<string>();
            }
        }

        public List<List<string>> get_all_quizz()
        {
            List<List<string>> quizzs = quizz_model.get_all_quizz();
            List<List<string>> ret = new List<List<string>>();
            foreach (List<string> quizz in quizzs)
            {
                int nb_questions = contains_model.get_question_number_from_quizz(quizz[0]);
                string theme_name = theme_model.get_theme_from_id(int.Parse(quizz[1]));

                ret.Add(new List<string> { quizz[0], nb_questions.ToString(), theme_name });
            }
            return ret;
        }

        public int add_question(int id_quizz, string name_question)
        {
            int question_id = question_model.get_id_from_name(name_question);
            int num_question = contains_model.get_last_num_question_from_quizz(id_quizz) + 1;
            if (question_id != -1)
            {
                contains_model.add_question_to_quizz(question_id, id_quizz, num_question);
                return 1;
            }
            return 0;
        }

        public void delete_quizz(string name)
        {
            quizz_model.delete_quizz(name);
        }

        public void create_quizz_without_questions(string name_quizz, string email_user)
        {
            int user_id = user_model.get_id_from_email(email_user);
            if (user_id != -1)
            {
                quizz_model.create_quizz_without_question(name_quizz, user_id, 1);
            }
        }

        public int get_id_quizz_from_name(string name)
        {
            return quizz_model.get_id_from_name(name);
        }

        public int get_latest_quizz_id()
        {
            return quizz_model.get_latest_quizz_id();
        }

        public string get_theme_quizz_from_id(int id_quizz)
        {
            int theme_id = quizz_model.get_theme_id_from_quizz_id(id_quizz);
            return theme_model.get_theme_from_id(theme_id);
        }

        public void update_quizz_from_id(string name_quizz, string name_theme, int id_quizz)
        {
            int id_theme = theme_model.get_id_from_name(name_theme);
            quizz_model.update_quizz_from_id(name_quizz, id_theme, id_quizz);
        }
    }
}
