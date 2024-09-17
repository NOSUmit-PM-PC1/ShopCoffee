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
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeProduct t = new TypeProduct("кофе");
            Product pr1 = new Product("эспрессо", 100, t);
            label1.Text = pr1.Title + " " + pr1.Cost + " " + pr1.TypeProduct;
            ListViewItem product1 = new ListViewItem(pr1.Title);
            product1.SubItems.Add(pr1.Cost.ToString());
            product1.SubItems.Add(pr1.TypeProduct.ToString());
            listViewCatalog.Items.Add(product1);
        }
    }
}
