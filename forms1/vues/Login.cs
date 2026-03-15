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
    public partial class Login : Form
    {
        private Main_controller main_controller;

        public Login()
        {
            Init init = new Init();
            main_controller = init.Main_controller;
            InitializeComponent();
        }

        public Main_controller Main_controller
        { get { return main_controller; } set { main_controller = value; } }

        private void btn_to_register_Click(object sender, EventArgs e)
        {
            load_page(new Register(main_controller));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            List<string> user = main_controller.User_controller.get_user(tb_email.Text, tb_password.Text);
            if (user == null || user.Count < 2)
            { 
                MessageBox.Show("Email ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Bienvenue sur CACAVENTURE " + user[0] + " " + user[1] + " !", "Bienvenue", MessageBoxButtons.OK);
            load_page(new Quizzes(main_controller, tb_email.Text));
        }

        public void load_login()
        {
            panel1.Controls.Clear();
            var loginView = new LoginUserControl(main_controller);
            loginView.Dock = DockStyle.Fill;
            panel1.Controls.Add(loginView);
        }

        public void load_page(UserControl user_control)
        {
            panel1.Controls.Clear();
            user_control.Dock = DockStyle.Fill;
            panel1.Controls.Add(user_control);
        }
    }
}
