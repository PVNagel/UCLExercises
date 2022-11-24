using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WPFex30.Model;

namespace WPFex30.ViewModel
{
    public class ProductRepo
    {
        List<Product> productRepo = new List<Product>();

        public ProductRepo()
        {
            InitializeRepo();
        }

        public void InitializeRepo()
        {
            Add("Apple", 7.95);
            Add("Orange", 5.50);
            Add("Banana", 8.25);
        }

        public Product Add(string name, double price)
        {
            Product result = new Product(name, price);
            productRepo.Add(result);

            return result;
        }

        public List<Product> GetAll()
        {
            return productRepo;
        }
    }
}
