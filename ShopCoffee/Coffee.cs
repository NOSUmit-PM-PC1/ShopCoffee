using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCoffee
{
    public class TypeProduct
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

    public class Product
    {
        static int count = 0;
        public int ID { get; }
        public string Title { get; }
        public decimal Cost { get; }
        public TypeProduct TypeProduct { get; }

        public Product(string title, decimal cost, TypeProduct typeProduct)
        {
            ID = count++;
            this.Title = title;
            this.Cost = cost;
            this.TypeProduct = typeProduct;
        }

        public override string ToString()
        {
            return $"{Title} {Cost} {TypeProduct}";
        }
    }
}
