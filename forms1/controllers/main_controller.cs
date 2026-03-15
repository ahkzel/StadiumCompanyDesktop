using System;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace forms1.controllers
{
    public class Main_controller
    {
        private MySqlConnection conn;
        private User_controller user_controller;
        private Quizz_controller quizz_controller;
        private Theme_controller theme_controller;
        private Question_controller question_controller;
        private Answer_controller answer_controller;

        public Main_controller(MySqlConnection Conn)
        {
            conn = Conn;
            user_controller = new User_controller(conn);
            quizz_controller = new Quizz_controller(conn);
            theme_controller = new Theme_controller(conn);
            question_controller = new Question_controller(conn);
            answer_controller = new Answer_controller(conn);
        }
        public MySqlConnection Conn
        { get { return conn; } set { conn = value; } }
        public User_controller User_controller
        { get { return user_controller; } set { user_controller = value; } }
        public Quizz_controller Quizz_controller
        { get { return quizz_controller; } set { quizz_controller = value; } }
        public Theme_controller Theme_controller
        { get { return theme_controller; } set { theme_controller = value; } }
        public Question_controller Question_controller
        { get { return question_controller; } set { question_controller = value; } }
        public Answer_controller Answer_controller
        { get { return answer_controller; } set { answer_controller = value; } }
    }
}
