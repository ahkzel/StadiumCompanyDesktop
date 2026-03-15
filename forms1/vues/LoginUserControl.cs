using forms1.controllers;
using forms1.models;

namespace forms1
{
    public partial class LoginUserControl : UserControl
    {
        private Main_controller main_controller;

        public LoginUserControl(Main_controller Main_controller)
        {
            main_controller = Main_controller;
            InitializeComponent();
        }

        public Main_controller Main_controller
        { get { return main_controller; } set { main_controller = value; } }

        private void btn_login_Click(object sender, EventArgs e)
        {
            List<string> user = main_controller.User_controller.get_user(tb_email.Text, tb_password.Text);
            if (user == null || user.Count < 2)
            {
                MessageBox.Show("Email ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var parent = this.FindForm() as Login;
            if (parent != null)
            {
                parent.load_page(new Quizzes(main_controller, tb_email.Text));
            }
        }

        private void btn_to_register_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as Login;
            if (parent != null)
            {
                parent.load_page(new Register(main_controller));
            }
        }
    }
}
