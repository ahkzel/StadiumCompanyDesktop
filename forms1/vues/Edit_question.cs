using System;
using forms1.controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Edit_question : UserControl
    {
        private Main_controller main_controller;
        private List<string> answers_list;
        private List<Abstract_answers> answers;
        private string name_question;
        private string name_quizz;
        private int id_quizz;
        private string email_user;

        public Edit_question(Main_controller Main_controller, string Name_question, string Name_quizz, int Id_quizz, string Email_user)
        {
            InitializeComponent();
            main_controller = Main_controller;
            tb_question_name.Text = name_question = Name_question;
            name_quizz = Name_quizz;
            id_quizz = Id_quizz;
            email_user = Email_user;
            if (name_question == "")
            {
                answers_list = new List<string>();
            }
            else
            {
                answers_list = main_controller.Answer_controller.get_answer_from_question_quizz(name_question, id_quizz);
            }

            create_answers();
            populate_cb_type();
            string existing_type = main_controller.Question_controller.get_type_from_question_quizz(name_question, id_quizz); 
            if (existing_type == "binaire") 
            { 
                cb_type.SelectedItem = "vrai/faux"; 
            } 
            else if (existing_type == "multiple") 
            { 
                cb_type.SelectedItem = "choix multiple"; 
            }
            populate_cb_answers();
            populate_cb_right_answer(answers_list);
        }

        public void create_answers()
        {
            answers = new List<Abstract_answers>();
            if (answers_list.Count == 0)
            {
                return;
            }
            foreach (var answer_label in answers_list)
            {
                answers.Add(new Abstract_answers { Name = answer_label });
            }
            refresh_answers();
        }

        public void populate_cb_type()
        {
            cb_type.Items.Add("vrai/faux");
            cb_type.Items.Add("choix multiple");
        }

        public void populate_cb_answers()
        {
            List<string> answers_;
            if (name_question == "")
            {
                answers_ = main_controller.Answer_controller.get_all_answers();
            }
            else
            {
                answers_ = main_controller.Answer_controller.get_answer_not_from_question(name_question, id_quizz);
            }
            cb_answers.Items.Clear();
            foreach (var answer in answers_)
            {
                cb_answers.Items.Add(answer);
            }
        }

        public void populate_cb_right_answer(List<string> answers)
        {
            cb_right_answer.Items.Clear();
            if (answers.Count == 0)
            {
                return;
            }
            foreach (var answer in answers)
            {
                cb_right_answer.Items.Add(answer);
            }
        }

        public void refresh_answers()
        {
            dgv_answers.DataSource = null;
            dgv_answers.DataSource = answers;
        }

        public void refresh_cb_answers()
        {
            List<string> all_answers = main_controller.Answer_controller.get_all_answers();
            cb_answers.Items.Clear();
            foreach (var answer in all_answers)
            {
                if (!answers_list.Contains(answer))
                {
                    cb_answers.Items.Add(answer);
                }
            }
        }

        public void refresh_cb_right_answer()
        {
            cb_right_answer.Items.Clear();
            foreach (var answer in answers_list)
            {
                cb_right_answer.Items.Add(answer);
            }
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.SelectedItem != null)
            {
                string selected_type = cb_type.SelectedItem.ToString();
                if (selected_type == "vrai/faux")
                {
                    lb_add_answer.Visible = false;
                    cb_answers.Visible = false;
                    bt_add_answer.Visible = false;
                    answers_list.Clear();
                    answers.Clear();
                    answers_list.Add("vrai");
                    answers_list.Add("faux");
                    answers.Add(new Abstract_answers { Name = "vrai" });
                    answers.Add(new Abstract_answers { Name = "faux" });
                    refresh_answers();
                    populate_cb_right_answer(answers_list);
                }
                else
                {
                    lb_add_answer.Visible = true;
                    cb_answers.Visible = true;
                    bt_add_answer.Visible = true;
                    answers_list.Clear();
                    answers.Clear();
                    refresh_answers();
                    populate_cb_right_answer(answers_list);
                    refresh_cb_answers();
                }
            }
        }

        private void bt_add_answer_Click(object sender, EventArgs e)
        {
            if (cb_answers.SelectedItem == null) 
            { 
                MessageBox.Show("Veuillez sélectionner une réponse à ajouter."); 
                return; 
            }
            string selected_answer = cb_answers.SelectedItem.ToString();
            if (!answers_list.Contains(selected_answer))
            {
                answers_list.Add(selected_answer);
                answers.Add(new Abstract_answers { Name = selected_answer });
                refresh_answers();
                refresh_cb_answers();
                populate_cb_right_answer(answers_list);
            }
        }

        private void bt_modify_Click(object sender, EventArgs e)
        {
            if (cb_type.SelectedItem == null || (cb_type.SelectedItem.ToString() != "vrai/faux" && answers_list.Count == 0) || cb_right_answer.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs ne sont pas remplis. Il manque le type, les réponses ou la réponse correct à la question.");
                return;
            }

            List<List<string>> existing_questions = main_controller.Question_controller.get_all_questions_from_quizz(id_quizz);
            string type_question = cb_type.SelectedItem.ToString();
            if (type_question == "vrai/faux")
            {
                type_question = "binaire";
            }
            else
            {
                type_question = "multiple";
            }
            string question_name = tb_question_name.Text;
            string right_answer = cb_right_answer.SelectedItem.ToString();
            string theme_quizz = main_controller.Quizz_controller.get_theme_quizz_from_id(id_quizz);
            int question_added = 0;

            foreach (List<string> question in existing_questions)
            {
                if (question[1] == name_question || question[1] == question_name)
                {
                    main_controller.Question_controller.update_question_from_name_and_quizz(name_question, question_name, id_quizz, type_question);
                    main_controller.Answer_controller.delete_answers_from_question_quizz(question_name, id_quizz);
                    question_added = 1;
                    break;
                }
            }
            if (question_added == 0)
            {
                main_controller.Question_controller.create_question_from_name_and_quizz(question_name, id_quizz, type_question);
            }
            main_controller.Answer_controller.add_answers_to_question_quizz(question_name, id_quizz, answers_list, right_answer, 1);

            var parent = this.FindForm() as Login;
            if (parent != null)
            {
                parent.load_page(new Edit_quizz(main_controller, name_quizz, theme_quizz, id_quizz, email_user));
            }
            return;
        }
    }
}
