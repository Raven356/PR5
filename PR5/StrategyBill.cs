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

        public void GetAmount()
        {
            Print print = new Print();
            foreach(var x in CBill.ConcreteBill())
            {
                print.PrintOnScreen($"Кількість {x.Key} банкнот - {x.Value.Count}");
            }
        }

        public decimal GetSum()
        {
            return CBill.GetSum();
        }
    }
}
