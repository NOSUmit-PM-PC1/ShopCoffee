using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCoffee
{
    public class Cart
    {
        public User user { get; }
        List<Tuple<Product, int>> listProducts = new List<Tuple<Product, int>>();

        public Cart(User user)
        {
            this.user = user;
        }

        public void Add(Product prod, int amount)
        {
            var t = Tuple.Create(prod, amount);
            listProducts.Add(t);
        }

        public override string ToString()
        {
            return listProducts[0].Item1.ToString() + " " + listProducts[0].Item2.ToString();
        }
    }
}
