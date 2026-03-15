using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class DGV_produits : UserControl
    {
        public List<Products> Products { get; set; }
        public DataGridViewRow Selected_row { get; set; }

        public DGV_produits()
        {
            Products = create_products();
            InitializeComponent();
        }

        private List<Products> create_products()
        {
            List<Products> products = new List<Products>
            {
                new Products { Id = 1, Name = "Produit 1", Price = 10.5M },
                new Products { Id = 2, Name = "Produit 2", Price = 20.75M },
                new Products { Id = 3, Name = "Produit 3", Price = 1 },
            };
            return products;
        }

        private void refresh_products()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Products;
        }

        private void bt_cache_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Id"].Visible = !dataGridView1.Columns["Id"].Visible;
        }

        private void bt_remplir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Products;
        }

        private void bt_add_product_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_id.Text) || string.IsNullOrWhiteSpace(tb_name.Text) || string.IsNullOrWhiteSpace(tb_price.Text))
            {
                MessageBox.Show("nan mais faut entrer des valeurs quand même enculé de ta mère :", "gros caca", MessageBoxButtons.YesNo);
                return;
            }

            int new_id = int.Parse(tb_id.Text);
            string new_name = tb_name.Text.ToString();
            decimal new_price = decimal.Parse(tb_price.Text);
            foreach (Products product in Products)
            {
                if (product.Id == new_id)
                {
                    new Troll_window().Show();
                    return;
                }
            }
            Products.Add(new Products { Id = new_id, Name = new_name, Price = new_price });
            refresh_products();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selected_row = dataGridView1.CurrentRow;
            tb_id.Text = selected_row.Cells[0].Value.ToString();
            tb_name.Text = selected_row.Cells[1].Value.ToString();
            tb_price.Text = selected_row.Cells[2].Value.ToString();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow selected_row = dataGridView1.CurrentRow;
            if (selected_row != null)
            {
                selected_row.Cells[0].Value = int.Parse(tb_id.Text);
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow selected_row = dataGridView1.CurrentRow;
            if (selected_row != null)
            {
                selected_row.Cells[1].Value = tb_name.Text.ToString();
            }
        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {
            DataGridViewRow selected_row = dataGridView1.CurrentRow;
            if (selected_row != null)
            {
                selected_row.Cells[2].Value = tb_price.Text.ToString();
            }
        }

        private void DGV_produits_Load(object sender, EventArgs e)
        {

        }
    }
}
