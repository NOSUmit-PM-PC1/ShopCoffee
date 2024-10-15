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
        public User ActiveUser { get; set; } = null;
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
            //activeUser = listUsers[0];
            //activeMenu = temp[0];
            menuItem_Click(temp[0], null);
            return temp.ToArray();
            
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (activeMenu != null)
            {
                activeMenu.Checked = false;
            }

            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuItem.Checked = true;
            activeMenu = menuItem;
            string userName = menuItem.Text;
            ActiveUser = FindUserByName(userName);
            //MessageBox.Show(menuItem.Text);
        }

        public void SetCurrentUserByName(string user)
        {
            ActiveUser = FindUserByName(user);
        }

        private User FindUserByName(string userName)
        {
            foreach (var user in listUsers)
                if (user.Name == userName)
                    return user;
            return null;
        }
    }

    public class User
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
