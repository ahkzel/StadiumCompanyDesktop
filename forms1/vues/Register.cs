using forms1.controllers;
using forms1.models;

namespace forms1
{
    public partial class Register : UserControl
    {
        private Main_controller main_controller;
        public Register(Main_controller Main_controller)
        {
            main_controller = Main_controller;
            InitializeComponent();
        }

        public Main_controller Main_controller
        { get { return main_controller; } set { main_controller = value; } }

        private void Register_Load(object sender, EventArgs e)
        {
             
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string return_message = main_controller.User_controller.add_user(tb_name.Text, tb_first_name.Text, tb_email.Text, tb_password.Text);
            MessageBox.Show(return_message, "Bravo !", MessageBoxButtons.OK);
            var parent = this.FindForm() as Login;
            if (parent != null) 
            { 
                parent.load_login(); 
            }
        }
    }
}
