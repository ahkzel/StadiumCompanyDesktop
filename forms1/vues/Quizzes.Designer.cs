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
            ((System.ComponentModel.ISupportInitialize)dgv_quizzes).BeginInit();
            cms_questionnaire.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_quizzes
            // 
            dgv_quizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_quizzes.ContextMenuStrip = cms_questionnaire;
            dgv_quizzes.Location = new Point(31, 90);
            dgv_quizzes.Margin = new Padding(3, 2, 3, 2);
            dgv_quizzes.MinimumSize = new Size(714, 366);
            dgv_quizzes.Name = "dgv_quizzes";
            dgv_quizzes.RowHeadersWidth = 51;
            dgv_quizzes.Size = new Size(714, 366);
            dgv_quizzes.TabIndex = 11;
            // 
            // cms_questionnaire
            // 
            cms_questionnaire.Items.AddRange(new ToolStripItem[] { modifierToolStripMenuItem, ajouterToolStripMenuItem, supprimToolStripMenuItem });
            cms_questionnaire.Name = "cms_questionnaire";
            cms_questionnaire.Size = new Size(130, 70);
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(129, 22);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(129, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            ajouterToolStripMenuItem.Click += ajouterToolStripMenuItem_Click;
            // 
            // supprimToolStripMenuItem
            // 
            supprimToolStripMenuItem.Name = "supprimToolStripMenuItem";
            supprimToolStripMenuItem.Size = new Size(129, 22);
            supprimToolStripMenuItem.Text = "Supprimer";
            supprimToolStripMenuItem.Click += supprimToolStripMenuItem_Click;
            // 
            // Quizzes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv_quizzes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Quizzes";
            Size = new Size(777, 477);
            ((System.ComponentModel.ISupportInitialize)dgv_quizzes).EndInit();
            cms_questionnaire.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_quizzes;
        private ContextMenuStrip cms_questionnaire;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem supprimToolStripMenuItem;
    }
}
