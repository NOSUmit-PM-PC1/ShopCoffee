using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCoffee
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            User newUser = new User(textBoxUserName.Text, textBoxUserAdress.Text, textBoxUserPassword.Text);
            Users temp = Users.DeSerialize();
            temp.Add(newUser);
            temp.Serialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBoxUserName.Clear();
            textBoxUserAdress.Clear();
            textBoxUserPassword.Clear();
        }
    }
}
