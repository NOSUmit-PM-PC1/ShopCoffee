using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ShopCoffee
{
    class Catalog
    {
        List<Product> list = new List<Product>();
        public void LoadFromFile(string filename = "Data/Data.txt")
        {
            TypeProduct type = null;

            StreamReader fileData = new StreamReader(filename);
            while (!fileData.EndOfStream)
            {
                string s = fileData.ReadLine();
                if (s.Contains("$"))
                {
                    string[] temp = s.Split('$');
                    Product pr = new Product(temp[0], Convert.ToDecimal(temp[1]), type);
                    list.Add(pr);
                }
                else
                {
                    type = new TypeProduct(s);
                }
            }
        }

        public ListViewItem[] ConvertToListView()
        {
            List<ListViewItem> tempList = new List<ListViewItem>();
            foreach (var prod in list)
            {
                ListViewItem product1 = new ListViewItem(prod.Title);
                product1.SubItems.Add(prod.Cost.ToString());
                product1.SubItems.Add(prod.TypeProduct.ToString());
                tempList.Add(product1);
            }
            return tempList.ToArray();
        }
    }
}
