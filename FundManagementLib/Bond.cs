﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundManagementLib
{
    public class Bond : Stock
    {
        public Bond(string name, decimal price, decimal quantity) : base(name, price, quantity)
        {
        }
        public override StockType StockType => StockType.Bond;
        public override decimal TransactionCost => MarketValue * 0.02M;
        public override decimal Tolerance => 100000;
    }
}
