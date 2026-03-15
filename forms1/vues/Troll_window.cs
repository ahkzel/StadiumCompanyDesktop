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
    public partial class Troll_window : Form
    {
        public Troll_window()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Random rnd = new Random();
            int maxX = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int maxY = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            int x = rnd.Next(0, maxX);
            int y = rnd.Next(0, maxY);
            this.Location = new Point(x, y);
        }

        private void bt_oui_Click(object sender, EventArgs e)
        {
            SpawnTwo();
        }

        private void SpawnTwo()
        {
            new Troll_window().Show();
            new Troll_window().Show();
        }

        private void bt_non_Click(object sender, EventArgs e)
        {
            SpawnTwo();
        }
    }
}
