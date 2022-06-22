using System;
using System.Collections.Generic;
using System.Text;

namespace PR5
{
    class Strategy5Cent : IMoneyStrategy
    {
        public Cent5Coin Cent5Coin { get; set; }
        public void Add(decimal val)
        {
            if(val == 5m)
                Cent5Coin.AddMoney(val);
        }

        public int GetAmount()
        {
            return Cent5Coin.Values.Count;
        }

        public decimal GetSum()
        {
            return Cent5Coin.GetSum();
        }
    }
}
