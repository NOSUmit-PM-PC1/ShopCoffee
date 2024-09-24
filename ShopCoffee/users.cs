using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCoffee
{
    class Users
    {
        List<User> listUsers = new List<User>();
        User activeUser = null;
        ToolStripMenuItem activeMenu = null;
        public void Add(User user)
        {
            listUsers.Add(user);
        }

        public ToolStripMenuItem[] ConvertToToolStripItem()
        {
            List<ToolStripMenuItem> temp = new List<ToolStripMenuItem> ();
            foreach (var item in listUsers)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(item.Name) { CheckOnClick = true };
                temp.Add(menuItem);
                menuItem.Click += new System.EventHandler(menuItem_Click);
            }
            return temp.ToArray();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (activeMenu != null)  activeMenu.Checked = false;
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            activeMenu = menuItem;
            MessageBox.Show(menuItem.Text);
        }
    }

    class User
    {
        public string Name { get; }
        public string Adress { get; }

        public User(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}
