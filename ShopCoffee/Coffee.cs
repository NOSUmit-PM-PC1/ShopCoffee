using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCoffee
{
    class TypeProduct
    {
        public string Name { get; }

        public TypeProduct(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Product
    {
        public string Title { get; }
        public decimal Cost { get; }
        public TypeProduct TypeProduct { get; }

        public Product(string title, decimal cost, TypeProduct typeProduct)
        {
            this.Title = title;
            this.Cost = cost;
            this.TypeProduct = typeProduct;
        }

    }
}
