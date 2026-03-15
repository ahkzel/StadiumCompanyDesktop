namespace forms1
{
    partial class Edit_question
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
            dgv_answers = new DataGridView();
            tb_question_name = new TextBox();
            cb_answers = new ComboBox();
            bt_add_answer = new Button();
            bt_modify = new Button();
            cb_right_answer = new ComboBox();
            lb_right_answer = new Label();
            lb_add_answer = new Label();
            cb_type = new ComboBox();
            lb_type = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_answers).BeginInit();
            SuspendLayout();
            // 
            // dgv_answers
            // 
            dgv_answers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_answers.Location = new Point(382, 51);
            dgv_answers.Margin = new Padding(3, 2, 3, 2);
            dgv_answers.Name = "dgv_answers";
            dgv_answers.RowHeadersWidth = 51;
            dgv_answers.Size = new Size(360, 296);
            dgv_answers.TabIndex = 0;
            // 
            // tb_question_name
            // 
            tb_question_name.Location = new Point(32, 51);
            tb_question_name.Margin = new Padding(3, 2, 3, 2);
            tb_question_name.Name = "tb_question_name";
            tb_question_name.Size = new Size(330, 23);
            tb_question_name.TabIndex = 1;
            // 
            // cb_answers
            // 
            cb_answers.FormattingEnabled = true;
            cb_answers.Location = new Point(32, 258);
            cb_answers.Margin = new Padding(3, 2, 3, 2);
            cb_answers.Name = "cb_answers";
            cb_answers.Size = new Size(330, 23);
            cb_answers.TabIndex = 2;
            // 
            // bt_add_answer
            // 
            bt_add_answer.Location = new Point(111, 325);
            bt_add_answer.Margin = new Padding(3, 2, 3, 2);
            bt_add_answer.Name = "bt_add_answer";
            bt_add_answer.Size = new Size(173, 27);
            bt_add_answer.TabIndex = 3;
            bt_add_answer.Text = "Ajouter la réponse";
            bt_add_answer.UseVisualStyleBackColor = true;
            bt_add_answer.Click += bt_add_answer_Click;
            // 
            // bt_modify
            // 
            bt_modify.Location = new Point(598, 389);
            bt_modify.Margin = new Padding(3, 2, 3, 2);
            bt_modify.Name = "bt_modify";
            bt_modify.Size = new Size(83, 28);
            bt_modify.TabIndex = 4;
            bt_modify.Text = "Modifier";
            bt_modify.UseVisualStyleBackColor = true;
            bt_modify.Click += bt_modify_Click;
            // 
            // cb_right_answer
            // 
            cb_right_answer.FormattingEnabled = true;
            cb_right_answer.Location = new Point(32, 182);
            cb_right_answer.Margin = new Padding(3, 2, 3, 2);
            cb_right_answer.Name = "cb_right_answer";
            cb_right_answer.Size = new Size(330, 23);
            cb_right_answer.TabIndex = 5;
            // 
            // lb_right_answer
            // 
            lb_right_answer.AutoSize = true;
            lb_right_answer.Location = new Point(32, 158);
            lb_right_answer.Name = "lb_right_answer";
            lb_right_answer.Size = new Size(104, 15);
            lb_right_answer.TabIndex = 6;
            lb_right_answer.Text = "Réponse correcte :";
            // 
            // lb_add_answer
            // 
            lb_add_answer.AutoSize = true;
            lb_add_answer.Location = new Point(32, 233);
            lb_add_answer.Name = "lb_add_answer";
            lb_add_answer.Size = new Size(120, 15);
            lb_add_answer.TabIndex = 7;
            lb_add_answer.Text = "Ajouter une réponse :";
            // 
            // cb_type
            // 
            cb_type.FormattingEnabled = true;
            cb_type.Location = new Point(32, 117);
            cb_type.Margin = new Padding(3, 2, 3, 2);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(330, 23);
            cb_type.TabIndex = 8;
            cb_type.SelectedIndexChanged += cb_type_SelectedIndexChanged;
            // 
            // lb_type
            // 
            lb_type.AutoSize = true;
            lb_type.Location = new Point(32, 89);
            lb_type.Name = "lb_type";
            lb_type.Size = new Size(115, 15);
            lb_type.TabIndex = 9;
            lb_type.Text = "Type de la question :";
            // 
            // Edit_question
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_type);
            Controls.Add(cb_type);
            Controls.Add(lb_add_answer);
            Controls.Add(lb_right_answer);
            Controls.Add(cb_right_answer);
            Controls.Add(bt_modify);
            Controls.Add(bt_add_answer);
            Controls.Add(cb_answers);
            Controls.Add(tb_question_name);
            Controls.Add(dgv_answers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Edit_question";
            Size = new Size(777, 477);
            ((System.ComponentModel.ISupportInitialize)dgv_answers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_answers;
        private TextBox tb_question_name;
        private ComboBox cb_answers;
        private Button bt_add_answer;
        private Button bt_modify;
        private ComboBox cb_right_answer;
        private Label lb_right_answer;
        private Label lb_add_answer;
        private ComboBox cb_type;
        private Label lb_type;
    }
}
