namespace forms1
{
    partial class Quizzes
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
            dgv_quizzes = new DataGridView();
            cms_questionnaire = new ContextMenuStrip(components);
            modifierToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            supprimToolStripMenuItem = new ToolStripMenuItem();
            lb_all_quizz = new Label();
            générerUnPdfToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv_quizzes).BeginInit();
            cms_questionnaire.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_quizzes
            // 
            dgv_quizzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_quizzes.BackgroundColor = SystemColors.ControlLight;
            dgv_quizzes.BorderStyle = BorderStyle.None;
            dgv_quizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_quizzes.ContextMenuStrip = cms_questionnaire;
            dgv_quizzes.Location = new Point(30, 88);
            dgv_quizzes.Margin = new Padding(3, 2, 3, 2);
            dgv_quizzes.MinimumSize = new Size(714, 366);
            dgv_quizzes.Name = "dgv_quizzes";
            dgv_quizzes.RowHeadersWidth = 51;
            dgv_quizzes.Size = new Size(714, 366);
            dgv_quizzes.TabIndex = 11;
            // 
            // cms_questionnaire
            // 
            cms_questionnaire.Items.AddRange(new ToolStripItem[] { modifierToolStripMenuItem, ajouterToolStripMenuItem, supprimToolStripMenuItem, générerUnPdfToolStripMenuItem });
            cms_questionnaire.Name = "cms_questionnaire";
            cms_questionnaire.Size = new Size(181, 114);
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(180, 22);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(180, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // supprimToolStripMenuItem
            // 
            supprimToolStripMenuItem.Name = "supprimToolStripMenuItem";
            supprimToolStripMenuItem.Size = new Size(180, 22);
            supprimToolStripMenuItem.Text = "Supprimer";
            supprimToolStripMenuItem.Click += supprimToolStripMenuItem_Click;
            // 
            // lb_all_quizz
            // 
            lb_all_quizz.AutoSize = true;
            lb_all_quizz.Font = new Font("Segoe UI", 10F);
            lb_all_quizz.Location = new Point(41, 47);
            lb_all_quizz.Name = "lb_all_quizz";
            lb_all_quizz.Size = new Size(229, 19);
            lb_all_quizz.TabIndex = 12;
            lb_all_quizz.Text = "Tous les questionnaires disponibles :";
            // 
            // générerUnPdfToolStripMenuItem
            // 
            générerUnPdfToolStripMenuItem.Name = "générerUnPdfToolStripMenuItem";
            générerUnPdfToolStripMenuItem.Size = new Size(180, 22);
            générerUnPdfToolStripMenuItem.Text = "Générer un pdf";
            générerUnPdfToolStripMenuItem.Click += générerUnPdfToolStripMenuItem_Click;
            // 
            // Quizzes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_all_quizz);
            Controls.Add(dgv_quizzes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Quizzes";
            Size = new Size(777, 477);
            ((System.ComponentModel.ISupportInitialize)dgv_quizzes).EndInit();
            cms_questionnaire.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_quizzes;
        private ContextMenuStrip cms_questionnaire;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem supprimToolStripMenuItem;
        private Label lb_all_quizz;
        private ToolStripMenuItem générerUnPdfToolStripMenuItem;
    }
}
