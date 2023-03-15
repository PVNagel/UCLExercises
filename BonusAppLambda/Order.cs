﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double valueOfProducts = 0;
            foreach (Product product in _products)
            {
                valueOfProducts += product.Value;
            }
            return valueOfProducts;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(Func<double, double> provider)
        {
            return provider(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
        public double GetTotalPrice(Func<double, double> providerPrice)
        {
            return GetValueOfProducts() - GetBonus(providerPrice);
        }
    }
}
