using forms1.controllers;
using System;
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
    public partial class Edit_quizz : UserControl
    {
        private Main_controller main_controller;
        private List<Abstract_questions> questions;
        private string name_quizz;
        private string theme_quizz;
        private int id_quizz;
        private string email_user;

        public Edit_quizz(Main_controller Main_controller, string Name_quizz, string Theme_quizz, int Id_quizz, string Email_user)
        {
            InitializeComponent();
            main_controller = Main_controller;
            List<List<string>> Questions = main_controller.Question_controller.get_all_questions_from_quizz(Id_quizz);
            tb_name.Text = name_quizz = Name_quizz;
            cb_theme.Text = theme_quizz = Theme_quizz;
            id_quizz = Id_quizz;
            email_user = Email_user;
            create_questions(Questions);
            populate_cb_theme();
            populate_cb_question();
        }

        public void create_questions(List<List<string>> Questions)
        {
            questions = new List<Abstract_questions>();
            foreach (var question in Questions)
            {
                questions.Add(new Abstract_questions { Num = int.Parse(question[0]), Name = question[1], Type = question[2] });
            }
            refresh_questions();
        }

        public void populate_cb_theme()
        {
            List<string> themes = main_controller.Theme_controller.get_all_theme();
            cb_theme.Items.Clear();
            foreach (var theme in themes)
            {
                cb_theme.Items.Add(theme);
            }
        }

        public void populate_cb_question()
        {
            List<string> questions = main_controller.Question_controller.get_questions_not_from_quizz(id_quizz);
            cb_questions.Items.Clear();
            foreach (var question in questions)
            {
                cb_questions.Items.Add(question);
            }
        }

        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme_quizz = cb_theme.SelectedItem.ToString();
        }

        public void refresh_questions()
        {
            dgv_questions.DataSource = null;
            dgv_questions.DataSource = questions;
        }


        private void ajouter_questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as Login;
            if (parent != null)
            {
                parent.load_page(new Edit_question(main_controller, "", name_quizz, id_quizz, email_user));
            }
        }

        private void modifier_questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var question_name = dgv_questions.CurrentRow.Cells["Name"].Value;
            var parent = this.FindForm() as Login;
            if (parent != null)
            {
                parent.load_page(new Edit_question(main_controller, question_name.ToString(), name_quizz, id_quizz, email_user));
            }
        }

        private void supprimer_questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_questions.SelectedRows != null)
            {
                var question_name = dgv_questions.SelectedRows[0].Cells["Name"].Value;
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette question ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes && question_name != null)
                {
                    main_controller.Question_controller.delete_question_from_name_and_quizz(question_name.ToString(), id_quizz);
                    var item = questions.FirstOrDefault(q => q.Name == question_name.ToString());
                    if (item != null)
                    {
                        questions.Remove(item);
                    }
                    refresh_questions();
                }
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            string name_quizz = tb_name.Text.ToString();
            if (name_quizz == "")
            {
                MessageBox.Show("Le nom du questionnaire ne peut pas être vide.");
                return;
            }

            List<List<string>> existing_quizzs = main_controller.Quizz_controller.get_all_quizz();
            foreach (var quizz in existing_quizzs)
            {
                int id_existing_quizz = main_controller.Quizz_controller.get_id_quizz_from_name(quizz[0]);
                if (quizz[0] == name_quizz && id_existing_quizz != id_quizz)
                {
                    MessageBox.Show("Un questionnaire avec ce nom existe déjà. Vous ne pouvez ajouter un quizz dont le nom est déjà pris.");
                    return;
                }
            }
            main_controller.Quizz_controller.update_quizz_from_id(name_quizz, theme_quizz, id_quizz);
            MessageBox.Show("Votre questionnaire a été modifié/ajouté avec succès !");
            var parent = this.FindForm() as Login;
            if (parent != null)
            {
                parent.load_page(new Quizzes(main_controller, email_user));
            }
        }

        private void bt_add_question_Click(object sender, EventArgs e)
        {
            if (cb_questions.SelectedItem != null)
            {
                string question_name = cb_questions.SelectedItem.ToString();
                foreach (Abstract_questions question in questions)
                {
                    if (question.Name == question_name)
                    {
                        MessageBox.Show("Cette question est déjà dans le questionnaire.");
                        return;
                    }
                }
                List<string> new_question = main_controller.Question_controller.get_question_from_name(question_name, id_quizz);
                questions.Add(new Abstract_questions { Num = int.Parse(new_question[0]), Name = new_question[1].ToString(), Type = new_question[2].ToString() });
                int ret = main_controller.Quizz_controller.add_question(id_quizz, question_name);
                if (ret == 1)
                {
                    MessageBox.Show("Question ajoutée avec succès !");
                }
                else if (ret == 0)
                {
                    MessageBox.Show("Cette question est déjà dans le questionnaire.");
                    return;
                }
                refresh_questions();
            }
        }
    }
}
