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
            ((System.ComponentModel.ISupportInitialize)dgv_questions).BeginInit();
            context_questions.SuspendLayout();
            SuspendLayout();
            // 
            // cb_theme
            // 
            cb_theme.FormattingEnabled = true;
            cb_theme.Location = new Point(558, 20);
            cb_theme.Name = "cb_theme";
            cb_theme.Size = new Size(193, 23);
            cb_theme.TabIndex = 0;
            cb_theme.SelectedIndexChanged += cb_theme_SelectedIndexChanged;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(24, 20);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(515, 23);
            tb_name.TabIndex = 1;
            // 
            // dgv_questions
            // 
            dgv_questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_questions.ContextMenuStrip = context_questions;
            dgv_questions.Location = new Point(24, 74);
            dgv_questions.Name = "dgv_questions";
            dgv_questions.RowHeadersWidth = 51;
            dgv_questions.Size = new Size(477, 329);
            dgv_questions.TabIndex = 2;
            // 
            // context_questions
            // 
            context_questions.ImageScalingSize = new Size(20, 20);
            context_questions.Items.AddRange(new ToolStripItem[] { ajouter_questionToolStripMenuItem, modifier_questionToolStripMenuItem, supprimer_questionToolStripMenuItem });
            context_questions.Name = "context_questions";
            context_questions.Size = new Size(181, 92);
            // 
            // ajouter_questionToolStripMenuItem
            // 
            ajouter_questionToolStripMenuItem.Name = "ajouter_questionToolStripMenuItem";
            ajouter_questionToolStripMenuItem.Size = new Size(180, 22);
            ajouter_questionToolStripMenuItem.Text = "ajouter_question";
            ajouter_questionToolStripMenuItem.Click += ajouter_questionToolStripMenuItem_Click;
            // 
            // modifier_questionToolStripMenuItem
            // 
            modifier_questionToolStripMenuItem.Name = "modifier_questionToolStripMenuItem";
            modifier_questionToolStripMenuItem.Size = new Size(180, 22);
            modifier_questionToolStripMenuItem.Text = "modifier_question";
            modifier_questionToolStripMenuItem.Click += modifier_questionToolStripMenuItem_Click;
            // 
            // supprimer_questionToolStripMenuItem
            // 
            supprimer_questionToolStripMenuItem.Name = "supprimer_questionToolStripMenuItem";
            supprimer_questionToolStripMenuItem.Size = new Size(180, 22);
            supprimer_questionToolStripMenuItem.Text = "supprimer_question";
            supprimer_questionToolStripMenuItem.Click += supprimer_questionToolStripMenuItem_Click;
            // 
            // bt_submit
            // 
            bt_submit.Location = new Point(606, 426);
            bt_submit.Name = "bt_submit";
            bt_submit.Size = new Size(133, 26);
            bt_submit.TabIndex = 3;
            bt_submit.Text = "Soumettre";
            bt_submit.UseVisualStyleBackColor = true;
            bt_submit.Click += bt_submit_Click;
            // 
            // cb_questions
            // 
            cb_questions.FormattingEnabled = true;
            cb_questions.Location = new Point(518, 111);
            cb_questions.Margin = new Padding(3, 2, 3, 2);
            cb_questions.Name = "cb_questions";
            cb_questions.Size = new Size(248, 23);
            cb_questions.TabIndex = 4;
            // 
            // bt_add_question
            // 
            bt_add_question.Location = new Point(578, 169);
            bt_add_question.Margin = new Padding(3, 2, 3, 2);
            bt_add_question.Name = "bt_add_question";
            bt_add_question.Size = new Size(128, 22);
            bt_add_question.TabIndex = 5;
            bt_add_question.Text = "Ajouter question";
            bt_add_question.UseVisualStyleBackColor = true;
            bt_add_question.Click += bt_add_question_Click;
            // 
            // Edit_quizz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
