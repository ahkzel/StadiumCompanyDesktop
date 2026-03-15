namespace forms1
{
    partial class LoginUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            lb_to_register = new Label();
            btn_to_register = new Button();
            btn_login = new Button();
            tb_password = new TextBox();
            label1 = new Label();
            tb_email = new TextBox();
            lb_email = new Label();
            SuspendLayout();
            // 
            // lb_to_register
            // 
            lb_to_register.AutoSize = true;
            lb_to_register.Location = new Point(342, 373);
            lb_to_register.Name = "lb_to_register";
            lb_to_register.Size = new Size(206, 20);
            lb_to_register.TabIndex = 22;
            lb_to_register.Text = "Vous n'avez pas de compte ? :";
            // 
            // btn_to_register
            // 
            btn_to_register.Location = new Point(380, 405);
            btn_to_register.Name = "btn_to_register";
            btn_to_register.Size = new Size(126, 33);
            btn_to_register.TabIndex = 21;
            btn_to_register.Text = "créer un compte";
            btn_to_register.UseVisualStyleBackColor = true;
            btn_to_register.Click += btn_to_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(394, 303);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(126, 33);
            btn_login.TabIndex = 20;
            btn_login.Text = "Connexion";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(367, 259);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(180, 27);
            tb_password.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 259);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 18;
            label1.Text = "Mot de passe :";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(367, 221);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(181, 27);
            tb_email.TabIndex = 17;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(310, 221);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(53, 20);
            lb_email.TabIndex = 16;
            lb_email.Text = "Email :";
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_to_register);
            Controls.Add(btn_to_register);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(label1);
            Controls.Add(tb_email);
            Controls.Add(lb_email);
            Name = "LoginUserControl";
            Size = new Size(888, 636);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_to_register;
        private Button btn_to_register;
        private Button btn_login;
        private TextBox tb_password;
        private Label label1;
        private TextBox tb_email;
        private Label lb_email;
    }
}
