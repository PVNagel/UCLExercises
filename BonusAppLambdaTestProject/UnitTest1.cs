using BonusApp;
using System.Reflection.Metadata.Ecma335;

namespace BonusAppLambdaTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Order order;

        [TestInitialize]
        public void InitializeTest()
        {
            order = new Order();
            order.AddProduct(new Product
            {
                Name = "M�lk",
                Value = 10.0
            });
            order.AddProduct(new Product
            {
                Name = "Sm�r",
                Value = 15.0
            });
            order.AddProduct(new Product
            {
                Name = "P�l�g",
                Value = 20.0
            });
        }
        [TestMethod]

        public void GetBonusAnonymous_Test()
        {
            //anonymous method
            order.Bonus = delegate (double amount) { return amount * 0.1; };

            Assert.AreEqual(4.5, order.GetBonus());

            //anonymous method
            order.Bonus = delegate (double amount) { if (amount > 5) { return 2.0; } else { return 0.0; }; };
            
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]

        public void GetBonusLambda_Test()
        {
            order.Bonus = amount => amount * 0.1;

            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = amount => { if (amount > 5) { return 2.0; } else { return 0.0; }; };

            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]

        public void GetBonusByLambdaParameter_Test()

        {

            // Use TenPercent lambda expresssion as parameter to GetBonus
            Assert.AreEqual(4.5, order.GetBonus(amount => amount * 0.1));

            // Use FlatTwoIfAmountMoreThanFive lambda expresssion as parameter to GetBonus
            Assert.AreEqual(2.0, order.GetBonus(amount => { if (amount > 5) { return 2.0; } else { return 0.0; }; } ));

        }

        [TestMethod]
        public void GetTotalPriceByLambdaParameter_Test()
        {
            Assert.AreEqual(40.5, order.GetTotalPrice(amount => amount * 0.1));

            Assert.AreEqual(43.0, order.GetTotalPrice(amount => { if (amount > 5) { return 2.0; } else { return 0.0; }; }));
        }

        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(4.5, Bonuses.TenPercent(45.0));
            Assert.AreEqual(40.0, Bonuses.TenPercent(400.0));
        }

        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, Bonuses.FlatTwoIfAmountMoreThanFive(10.0));
            Assert.AreEqual(0.0, Bonuses.FlatTwoIfAmountMoreThanFive(4.0));
        }

        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(45.0, order.GetValueOfProducts());
        }

        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(40.5, order.GetTotalPrice());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(43.0, order.GetTotalPrice());
        }
    }

}