using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCoffee
{
    public class ItemCart
    {
        int amount;

        public ItemCart(Product product, int amount)
        {
            this.Product = product;
            this.amount = amount;
        }

        public Product Product { get; set; }
        public int Amount
        {
            get
            {
                return amount;
                
            }
            set
            {
                if (value > 0)
                    amount = value;
            }
        }
    }
    public class Cart
    {
        public User user { get; }
        List<ItemCart> listProducts = new List<ItemCart>();

        public Cart(User user)
        {
            this.user = user;
        }

        public void Add(Product prod, int amount)
        {
            var itemCart = new ItemCart(prod, amount);
            listProducts.Add(itemCart);
        }

        public override string ToString()
        {
            return listProducts[0].Product + " " + listProducts[0].Amount.ToString();
        }

        public void Increase(int idProduct)
        {
            foreach (var item in listProducts)
            {
                if (idProduct == item.Product.ID)
                {
                    item.Amount = item.Amount + 1;
                    break;
                }
            }
        }

        public void Decrease(int idProduct)
        {
            foreach (var item in listProducts)
            {
                if (idProduct == item.Product.ID)
                {
                    if (item.Amount == 1)
                        DeleteItem(idProduct);
                    else                    
                        item.Amount = item.Amount - 1;
                    break;
                }
            }
        }
        public ItemCart FindItemCartFromId(int id)
        {
            foreach (var item in listProducts)
            {
                if (item.Product.ID == id)
                    return item;
            }
            return null;
        }

        public void DeleteItem(int id)
        {
            listProducts.Remove(FindItemCartFromId(id));
        }

        public void ShowCart(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (var item in listProducts)
            {
                dg.Rows.Add(new object[] { item.Product.ID, item.Product.Title, item.Product.Cost, "-", item.Amount, "+" });
            }
        }
    }
}
