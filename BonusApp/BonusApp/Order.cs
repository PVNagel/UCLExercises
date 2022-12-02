using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        List<Product> products = new List<Product>();

        public Order()
        {
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double result = 0;
            foreach (Product p in products)
            {
                result = result + p.Value;
            }
            return result;
        }

        public double GetBonus()
        {
            double result;
            result = Bonus(GetValueOfProducts());
            return result;
        }

        public double GetTotalPrice()
        {
            double result = GetValueOfProducts();
            result = result - Bonus(GetValueOfProducts());
            return result;
        }
    }
}
