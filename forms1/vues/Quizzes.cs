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
using System.Xml.Linq;

namespace forms1
{
    public partial class Quizzes : UserControl
    {
        private Main_controller main_controller;
        private List<Abstract_quizzes> quizzs;
        private string email_user;

        public Quizzes(Main_controller Main_controller, string Email_user)
        {
            InitializeComponent();
            main_controller = Main_controller;
            List<List<string>> Quizzs = main_controller.Quizz_controller.get_all_quizz();
            create_quizzes(Quizzs);
            dgv_quizzes.DataSource = quizzs;
            email_user = Email_user;
        }

        public Main_controller Main_controller
        { get { return main_controller; } set { main_controller = value; } }

        private void create_quizzes(List<List<string>> Quizzs)
        {
            quizzs = new List<Abstract_quizzes>();
            foreach (var quizz in Quizzs)
            {
                quizzs.Add(new Abstract_quizzes { Name = quizz[0], Nb_questions = int.Parse(quizz[1]), Theme = quizz[2] });
            }
        }

        private void refresh_quizzes()
        {
            dgv_quizzes.DataSource = null;
            dgv_quizzes.DataSource = quizzs;
        }


        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_quizzes.CurrentRow != null)
            {
                var name = dgv_quizzes.CurrentRow.Cells["Name"].Value;
                var theme = dgv_quizzes.CurrentRow.Cells["Theme"].Value;
                int id_quizz = main_controller.Quizz_controller.get_id_quizz_from_name(name.ToString());
                var parent = this.FindForm() as Login;
                if (parent != null)
                {
                    parent.load_page(new Edit_quizz(main_controller, name.ToString(), theme.ToString(), id_quizz, email_user));
                }
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as Login;
            main_controller.Quizz_controller.create_quizz_without_questions("l", email_user);
            int id_quizz = main_controller.Quizz_controller.get_latest_quizz_id();
            if (parent != null)
            {
                parent.load_page(new Edit_quizz(main_controller, "", "", id_quizz, email_user));
            }
        }

        private void supprimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_quizzes.CurrentRow != null)
            {
                var name = dgv_quizzes.CurrentRow.Cells["Name"].Value;
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce quizz ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes && name != null)
                {
                    main_controller.Quizz_controller.delete_quizz(name.ToString());
                    quizzs.Remove(quizzs.FirstOrDefault(q => q.Name == name.ToString()));
                    refresh_quizzes();
                }
            }
        }
    }
}
