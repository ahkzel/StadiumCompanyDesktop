namespace forms1
{
    partial class Register
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
            tb_password = new TextBox();
            label1 = new Label();
            tb_name = new TextBox();
            tb_email = new TextBox();
            btn_register = new Button();
            tb_first_name = new TextBox();
            lb_nom = new Label();
            lb_email = new Label();
            lb_prenom = new Label();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Location = new Point(368, 335);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(180, 27);
            tb_password.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 335);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 16;
            label1.Text = "Mot de passe :";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(368, 213);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(180, 27);
            tb_name.TabIndex = 11;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(368, 297);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(181, 27);
            tb_email.TabIndex = 15;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(377, 379);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(159, 33);
            btn_register.TabIndex = 9;
            btn_register.Text = "Créer mon compte";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // tb_first_name
            // 
            tb_first_name.Location = new Point(368, 257);
            tb_first_name.Name = "tb_first_name";
            tb_first_name.Size = new Size(180, 27);
            tb_first_name.TabIndex = 14;
            // 
            // lb_nom
            // 
            lb_nom.AutoSize = true;
            lb_nom.Location = new Point(314, 216);
            lb_nom.Name = "lb_nom";
            lb_nom.Size = new Size(49, 20);
            lb_nom.TabIndex = 10;
            lb_nom.Text = "Nom :";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(311, 297);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(53, 20);
            lb_email.TabIndex = 13;
            lb_email.Text = "Email :";
            // 
            // lb_prenom
            // 
            lb_prenom.AutoSize = true;
            lb_prenom.Location = new Point(296, 257);
            lb_prenom.Name = "lb_prenom";
            lb_prenom.Size = new Size(67, 20);
            lb_prenom.TabIndex = 12;
            lb_prenom.Text = "Prenom :";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_password);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Controls.Add(tb_email);
            Controls.Add(btn_register);
            Controls.Add(tb_first_name);
            Controls.Add(lb_nom);
            Controls.Add(lb_email);
            Controls.Add(lb_prenom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Size = new Size(888, 636);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_password;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_email;
        private Button btn_register;
        private TextBox tb_first_name;
        private Label lb_nom;
        private Label lb_email;
        private Label lb_prenom;
    }
}
