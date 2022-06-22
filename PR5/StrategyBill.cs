using System;
using System.Collections.Generic;
using System.Text;

namespace PR5
{
    class StrategyBill : IMoneyStrategy
    {
        public Bill CBill { get; set; }
        public void Add(decimal val)
        {
            CBill.AddMoney(val);
        }

        public int GetAmount()
        {
            return CBill.Values.Count;
        }

        public decimal GetSum()
        {
            return CBill.GetSum();
        }
    }
}
