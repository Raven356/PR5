using System;
using System.Collections.Generic;
using System.Text;

namespace PR5
{
    class Strategy10Cent : IMoneyStrategy
    {
        public Cent10Coin Cent10Coin
        {
            get; set;
        }
        public void Add(decimal val)
        {
            if(val == 10m)
                Cent10Coin.AddMoney(val);
        }
        public void GetAmount()
        {
            new Print().PrintOnScreen($"Кількість - {Cent10Coin.Values.Count}");
        }
        public decimal GetSum()
        {
            return Cent10Coin.GetSum()/100;
        }
    }
}
