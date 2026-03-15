namespace forms1
{
    partial class DGV_produits
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
            bt_add_product = new Button();
            tb_price = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lb_price = new Label();
            lb_name = new Label();
            lb_id = new Label();
            bt_cache = new Button();
            bt_remplir = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bt_add_product
            // 
            bt_add_product.Location = new Point(518, 318);
            bt_add_product.Margin = new Padding(3, 2, 3, 2);
            bt_add_product.Name = "bt_add_product";
            bt_add_product.Size = new Size(125, 22);
            bt_add_product.TabIndex = 19;
            bt_add_product.Text = "ajouter produit";
            bt_add_product.UseVisualStyleBackColor = true;
            bt_add_product.Click += bt_add_product_Click;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(563, 275);
            tb_price.Margin = new Padding(3, 2, 3, 2);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(110, 23);
            tb_price.TabIndex = 18;
            tb_price.TextChanged += tb_price_TextChanged;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(563, 227);
            tb_name.Margin = new Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(110, 23);
            tb_name.TabIndex = 17;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(563, 178);
            tb_id.Margin = new Padding(3, 2, 3, 2);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(110, 23);
            tb_id.TabIndex = 16;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new Point(488, 277);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(33, 15);
            lb_price.TabIndex = 15;
            lb_price.Text = "Price";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(488, 227);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(39, 15);
            lb_name.TabIndex = 14;
            lb_name.Text = "Name";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(488, 180);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(17, 15);
            lb_id.TabIndex = 13;
            lb_id.Text = "Id";
            // 
            // bt_cache
            // 
            bt_cache.Location = new Point(295, 109);
            bt_cache.Margin = new Padding(3, 2, 3, 2);
            bt_cache.Name = "bt_cache";
            bt_cache.Size = new Size(82, 22);
            bt_cache.TabIndex = 12;
            bt_cache.Text = "Cache id";
            bt_cache.UseVisualStyleBackColor = true;
            bt_cache.Click += bt_cache_Click;
            // 
            // bt_remplir
            // 
            bt_remplir.Location = new Point(111, 109);
            bt_remplir.Margin = new Padding(3, 2, 3, 2);
            bt_remplir.Name = "bt_remplir";
            bt_remplir.Size = new Size(82, 22);
            bt_remplir.TabIndex = 11;
            bt_remplir.Text = "Remplir";
            bt_remplir.UseVisualStyleBackColor = true;
            bt_remplir.Click += bt_remplir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(94, 158);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(367, 173);
            dataGridView1.TabIndex = 10;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // DGV_produits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bt_add_product);
            Controls.Add(tb_price);
            Controls.Add(tb_name);
            Controls.Add(tb_id);
            Controls.Add(lb_price);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(bt_cache);
            Controls.Add(bt_remplir);
            Controls.Add(dataGridView1);
            Name = "DGV_produits";
            Size = new Size(777, 477);
            Load += DGV_produits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_add_product;
        private TextBox tb_price;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lb_price;
        private Label lb_name;
        private Label lb_id;
        private Button bt_cache;
        private Button bt_remplir;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
    }
}
