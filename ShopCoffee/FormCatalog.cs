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
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart cartAlan = new Cart(new User("Vasya", "Vladik"));
            try
            {
                int id = Convert.ToInt32(listViewCatalog.SelectedItems[0].SubItems[3].Text);
                Product product = catalog.FindProductFromId(id);
                cartAlan.Add(product, 3);
                dataGridViewCart.Rows.Add(new object[]{product.ID, product.ToString(), product.Cost, "-", 1, "+"});

            }
            catch
            {
                MessageBox.Show("Выберите продукт");
            }
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

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            
            catalog.LoadFromFile();
            listViewCatalog.Items.AddRange(catalog.ConvertToListView());

            Users users = new Users();
            User alan = new User("Алан", "Владикавказ, Церетели 16, 6 этаж, 601");
            users.Add(alan);
            users.Add(new User("Залина", "Владикавказ, Владивостокская, 97б, 38"));

            toolStripMenuUsers.DropDownItems.AddRange(users.ConvertToToolStripItem());


        }

        private void zsdfghsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
