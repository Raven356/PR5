using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR5
{
    class Coin : Money
    {
        public decimal GetSum()
        {
            return Values.Sum() * 0.01m;
        }
    }
}
