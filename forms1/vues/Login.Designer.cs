namespace forms1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_password = new TextBox();
            label1 = new Label();
            tb_email = new TextBox();
            lb_email = new Label();
            btn_login = new Button();
            btn_to_register = new Button();
            lb_to_register = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Location = new Point(374, 239);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(180, 27);
            tb_password.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 239);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 11;
            label1.Text = "Mot de passe :";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(374, 201);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(181, 27);
            tb_email.TabIndex = 10;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(317, 201);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(53, 20);
            lb_email.TabIndex = 9;
            lb_email.Text = "Email :";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(401, 283);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(126, 33);
            btn_login.TabIndex = 13;
            btn_login.Text = "Connexion";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_to_register
            // 
            btn_to_register.Location = new Point(387, 385);
            btn_to_register.Name = "btn_to_register";
            btn_to_register.Size = new Size(126, 33);
            btn_to_register.TabIndex = 14;
            btn_to_register.Text = "créer un compte";
            btn_to_register.UseVisualStyleBackColor = true;
            btn_to_register.Click += btn_to_register_Click;
            // 
            // lb_to_register
            // 
            lb_to_register.AutoSize = true;
            lb_to_register.Location = new Point(349, 353);
            lb_to_register.Name = "lb_to_register";
            lb_to_register.Size = new Size(206, 20);
            lb_to_register.TabIndex = 15;
            lb_to_register.Text = "Vous n'avez pas de compte ? :";
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_to_register);
            panel1.Controls.Add(btn_to_register);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(tb_password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_email);
            panel1.Controls.Add(lb_email);
            panel1.Location = new Point(-2, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 636);
            panel1.TabIndex = 16;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 633);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_password;
        private Label label1;
        private TextBox tb_email;
        private Label lb_email;
        private Button btn_login;
        private Button btn_to_register;
        private Label lb_to_register;
        private Panel panel1;
    }
}