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
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        Cart currentUserCart = null;
        Users users;

        public FormCatalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentUserCart == null)
                {
                    if (users.ActiveUser != null)
                    {
                        currentUserCart = new Cart(users.ActiveUser);
                    }
                }
                toolStripStatusLabelUserName.Text = currentUserCart.user.Name;
                int id = Convert.ToInt32(listViewCatalog.SelectedItems[0].SubItems[3].Text);
                Product product = catalog.FindProductFromId(id);
                currentUserCart.Add(product, 1);
                currentUserCart.ShowCart(dataGridViewCart);
            }
            catch
            {
                MessageBox.Show("Выберите продукт или пользователя");
            }
            {
                //cartAlan.Add()


                //TypeProduct t = new TypeProduct("кофе");
                //Product pr1 = new Product("эспрессо", 100, t);
                //label1.Text = pr1.Title + " " + pr1.Cost + " " + pr1.TypeProduct;
                //Product pr2 = new Product("латте", 150, t);
                //List<Product> catalog = new List<Product> { pr1, pr2};


                ////ListViewItem product1 = new ListViewItem(pr1.Title);
                ////product1.SubItems.Add(pr1.Cost.ToString());
                ////product1.SubItems.Add(pr1.TypeProduct.ToString());
                //ListViewItem product1 = new ListViewItem(new string[] { pr1.Title, pr1.Cost.ToString(), pr1.TypeProduct.ToString() });
                //listViewCatalog.Items.Add(product1);
            }
        }



        private void FormCatalog_Load(object sender, EventArgs e)
        {
            
            catalog.LoadFromFile();
            

            users = new Users();
            User alan = new User("Алан", "Владикавказ, Церетели 16, 6 этаж, 601");
            users.Add(alan);
            users.Add(new User("Залина", "Владикавказ, Владивостокская, 97б, 38"));

           

        }

        private void zsdfghsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());
            switch (e.ColumnIndex)
            {
                case 5:
                    {
                        var idProduct = dataGridViewCart.Rows[e.RowIndex].Cells[0].Value;
                        currentUserCart.Increase(Convert.ToInt32(idProduct));
                        currentUserCart.ShowCart(dataGridViewCart);
                        break;// уменьшить количество
                    }
                   
                case 3:
                    {
                        var t = dataGridViewCart.Rows[e.RowIndex].Cells[0].Value;
                        currentUserCart.Decrease(Convert.ToInt32(t));
                        currentUserCart.ShowCart(dataGridViewCart);
                        break;
                    }
                    //увеличить количество
            }
                
            
          
        }

        private void FormCatalog_Activated(object sender, EventArgs e)
        {
            listViewCatalog.Items.AddRange(catalog.ConvertToListView());
            toolStripMenuUsers.DropDownItems.AddRange(users.ConvertToToolStripItem());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            users.SetCurrentUserByName("Алан");
            users
            currentUserCart = 
            toolStripStatusLabelUserName.Text = currentUserCart.user.Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            users.SetCurrentUserByName("Залина");
            toolStripStatusLabelUserName.Text = currentUserCart.user.Name;
        }
    }
}
