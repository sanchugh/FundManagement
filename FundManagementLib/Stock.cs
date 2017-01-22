using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManagementLib
{
    public abstract class Stock
    {
        protected decimal _stockWeight;
        public abstract StockType StockType { get; }
        public string StockName { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal MarketValue => Price * Quantity;
        public abstract decimal TransactionCost { get; }
        public abstract decimal Tolerance { get; }
        public string StockWeight { get { return _stockWeight.ToString("N3"); } }
        public void AdjustStockWeight(decimal totalMarketValue)
        {
            _stockWeight = totalMarketValue == 0 ? 0 : (MarketValue * 100) / totalMarketValue;
        }
        public decimal GetStockWeight()
        {
            return _stockWeight;
        }
        protected Stock(string name, decimal price, decimal quantity)
        {
            StockName = name;
            Price = price;
            Quantity = quantity;
        }

        public bool ToleranceBreached => MarketValue < 0 || TransactionCost > Tolerance;
    }
}
