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
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double valueOfProducts = 0;
            valueOfProducts = _products.Sum(x => x.Value);
            return valueOfProducts;
        }

        public double GetValueOfProducts(DateTime date)
        {
            double valueOfProducts = 0;
            List<Product> productList = _products.Where(product => product.AvailableFrom <= date && date <= product.AvailableTo).ToList();
            productList.ToList().ForEach(product => valueOfProducts += product.Value);
            return valueOfProducts;
        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            List<Product> productList = _products.OrderBy(product => product.AvailableTo).ToList();
            return productList;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
