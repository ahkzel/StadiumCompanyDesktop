using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1.controllers
{
    public class Navigation_controller
    {
        private Panel container;
        private Dictionary<string, UserControl> pages = new();

        public Navigation_controller(Panel Container)
        {
            container = Container;
        }

        public void register_page(string key, UserControl page)
        {
            pages[key] = page;
        }

        public void navigate(string key)
        {
            if (!pages.ContainsKey(key))
                return;

            var page = pages[key];
            page.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(page);
        }

        public bool exists(string key)
        {
            return pages.ContainsKey(key);
        }

        public UserControl get_page(string key)
        {
            return pages[key];
        }

    }
}
