namespace forms1
{
    partial class Edit_quizz
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
            components = new System.ComponentModel.Container();
            cb_theme = new ComboBox();
            tb_name = new TextBox();
            dgv_questions = new DataGridView();
            context_questions = new ContextMenuStrip(components);
            ajouter_questionToolStripMenuItem = new ToolStripMenuItem();
            modifier_questionToolStripMenuItem = new ToolStripMenuItem();
            supprimer_questionToolStripMenuItem = new ToolStripMenuItem();
            bt_submit = new Button();
            cb_questions = new ComboBox();
            bt_add_question = new Button();
            lb_quizz_content = new Label();
            lb_add_question = new Label();
            lb_quizz_name = new Label();
            lb_quizz_theme = new Label();
            bt_return = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_questions).BeginInit();
            context_questions.SuspendLayout();
            SuspendLayout();
            // 
            // cb_theme
            // 
            cb_theme.FormattingEnabled = true;
            cb_theme.Location = new Point(566, 103);
            cb_theme.Name = "cb_theme";
            cb_theme.Size = new Size(193, 23);
            cb_theme.TabIndex = 0;
            cb_theme.SelectedIndexChanged += cb_theme_SelectedIndexChanged;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(27, 103);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(515, 23);
            tb_name.TabIndex = 1;
            // 
            // dgv_questions
            // 
            dgv_questions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_questions.BackgroundColor = SystemColors.ControlLight;
            dgv_questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_questions.ContextMenuStrip = context_questions;
            dgv_questions.Location = new Point(27, 193);
            dgv_questions.Name = "dgv_questions";
            dgv_questions.RowHeadersWidth = 51;
            dgv_questions.Size = new Size(477, 256);
            dgv_questions.TabIndex = 2;
            // 
            // context_questions
            // 
            context_questions.ImageScalingSize = new Size(20, 20);
            context_questions.Items.AddRange(new ToolStripItem[] { ajouter_questionToolStripMenuItem, modifier_questionToolStripMenuItem, supprimer_questionToolStripMenuItem });
            context_questions.Name = "context_questions";
            context_questions.Size = new Size(180, 70);
            // 
            // ajouter_questionToolStripMenuItem
            // 
            ajouter_questionToolStripMenuItem.Name = "ajouter_questionToolStripMenuItem";
            ajouter_questionToolStripMenuItem.Size = new Size(179, 22);
            ajouter_questionToolStripMenuItem.Text = "ajouter_question";
            ajouter_questionToolStripMenuItem.Click += ajouter_questionToolStripMenuItem_Click;
            // 
            // modifier_questionToolStripMenuItem
            // 
            modifier_questionToolStripMenuItem.Name = "modifier_questionToolStripMenuItem";
            modifier_questionToolStripMenuItem.Size = new Size(179, 22);
            modifier_questionToolStripMenuItem.Text = "modifier_question";
            modifier_questionToolStripMenuItem.Click += modifier_questionToolStripMenuItem_Click;
            // 
            // supprimer_questionToolStripMenuItem
            // 
            supprimer_questionToolStripMenuItem.Name = "supprimer_questionToolStripMenuItem";
            supprimer_questionToolStripMenuItem.Size = new Size(179, 22);
            supprimer_questionToolStripMenuItem.Text = "supprimer_question";
            supprimer_questionToolStripMenuItem.Click += supprimer_questionToolStripMenuItem_Click;
            // 
            // bt_submit
            // 
            bt_submit.BackColor = SystemColors.ButtonFace;
            bt_submit.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            bt_submit.FlatAppearance.BorderSize = 0;
            bt_submit.Location = new Point(606, 423);
            bt_submit.Name = "bt_submit";
            bt_submit.Size = new Size(133, 29);
            bt_submit.TabIndex = 3;
            bt_submit.Text = "Soumettre";
            bt_submit.UseVisualStyleBackColor = false;
            bt_submit.Click += bt_submit_Click;
            // 
            // cb_questions
            // 
            cb_questions.FormattingEnabled = true;
            cb_questions.Location = new Point(520, 193);
            cb_questions.Margin = new Padding(3, 2, 3, 2);
            cb_questions.Name = "cb_questions";
            cb_questions.Size = new Size(248, 23);
            cb_questions.TabIndex = 4;
            // 
            // bt_add_question
            // 
            bt_add_question.Location = new Point(581, 240);
            bt_add_question.Margin = new Padding(3, 2, 3, 2);
            bt_add_question.Name = "bt_add_question";
            bt_add_question.Size = new Size(128, 33);
            bt_add_question.TabIndex = 5;
            bt_add_question.Text = "Ajouter question";
            bt_add_question.UseVisualStyleBackColor = true;
            bt_add_question.Click += bt_add_question_Click;
            // 
            // lb_quizz_content
            // 
            lb_quizz_content.AutoSize = true;
            lb_quizz_content.Font = new Font("Segoe UI", 10F);
            lb_quizz_content.Location = new Point(27, 154);
            lb_quizz_content.Name = "lb_quizz_content";
            lb_quizz_content.Size = new Size(169, 19);
            lb_quizz_content.TabIndex = 6;
            lb_quizz_content.Text = "Contenu du questionnaire";
            // 
            // lb_add_question
            // 
            lb_add_question.AutoSize = true;
            lb_add_question.Location = new Point(520, 158);
            lb_add_question.Name = "lb_add_question";
            lb_add_question.Size = new Size(124, 15);
            lb_add_question.TabIndex = 7;
            lb_add_question.Text = "Ajouter une question :";
            // 
            // lb_quizz_name
            // 
            lb_quizz_name.AutoSize = true;
            lb_quizz_name.Font = new Font("Segoe UI", 10F);
            lb_quizz_name.Location = new Point(27, 69);
            lb_quizz_name.Name = "lb_quizz_name";
            lb_quizz_name.Size = new Size(181, 19);
            lb_quizz_name.TabIndex = 8;
            lb_quizz_name.Text = "Nom de votre questionnaire";
            // 
            // lb_quizz_theme
            // 
            lb_quizz_theme.AutoSize = true;
            lb_quizz_theme.Font = new Font("Segoe UI", 10F);
            lb_quizz_theme.Location = new Point(566, 69);
            lb_quizz_theme.Name = "lb_quizz_theme";
            lb_quizz_theme.Size = new Size(157, 19);
            lb_quizz_theme.TabIndex = 9;
            lb_quizz_theme.Text = "Thème du questionnaire";
            // 
            // bt_return
            // 
            bt_return.FlatAppearance.BorderSize = 0;
            bt_return.Font = new Font("Segoe UI", 10F);
            bt_return.Location = new Point(27, 17);
            bt_return.Name = "bt_return";
            bt_return.Size = new Size(81, 30);
            bt_return.TabIndex = 10;
            bt_return.Text = "← retour  ";
            bt_return.UseVisualStyleBackColor = true;
            bt_return.Click += bt_return_Click;
            // 
            // Edit_quizz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_return);
            Controls.Add(lb_quizz_theme);
            Controls.Add(lb_quizz_name);
            Controls.Add(lb_add_question);
            Controls.Add(lb_quizz_content);
            Controls.Add(bt_add_question);
            Controls.Add(cb_questions);
            Controls.Add(bt_submit);
            Controls.Add(dgv_questions);
            Controls.Add(tb_name);
            Controls.Add(cb_theme);
            Name = "Edit_quizz";
            Size = new Size(777, 477);
            ((System.ComponentModel.ISupportInitialize)dgv_questions).EndInit();
            context_questions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_theme;
        private TextBox tb_name;
        private DataGridView dgv_questions;
        private ContextMenuStrip context_questions;
        private ToolStripMenuItem ajouter_questionToolStripMenuItem;
        private ToolStripMenuItem modifier_questionToolStripMenuItem;
        private ToolStripMenuItem supprimer_questionToolStripMenuItem;
        private Button bt_submit;
        private ComboBox cb_questions;
        private Button bt_add_question;
        private Label lb_quizz_content;
        private Label lb_add_question;
        private Label lb_quizz_name;
        private Label lb_quizz_theme;
        private Button bt_return;
    }
}
