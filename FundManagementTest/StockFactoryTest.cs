using FundManagementLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManagementTest
{
    [TestClass]
    public class StockFactoryTest
    {
        [TestMethod]
        public void CreateBondTest()
        {
            var factory = new StockFactory();

            var stock = factory.CreateStock(StockType.Bond, "Bond1", 1500, 500);

            Assert.AreEqual(stock.Price, 1500);
            Assert.AreEqual(stock.Quantity, 500);
            Assert.AreEqual(stock.MarketValue, 1500 * 500);
            Assert.AreEqual(stock.TransactionCost, 1500 * 500 * 0.02M);
        }

        [TestMethod]
        public void CreateEquityTest()
        {
            var factory = new StockFactory();

            var stock = factory.CreateStock(StockType.Equity, "Equity1", 1500, 500);

            Assert.AreEqual(stock.Price, 1500);
            Assert.AreEqual(stock.Quantity, 500);
            Assert.AreEqual(stock.MarketValue, 1500 * 500);
            Assert.AreEqual(stock.TransactionCost, 1500 * 500 * 0.005M);
        }
    }
}
