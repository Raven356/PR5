using System;
using System.Collections.Generic;
using System.Text;

namespace PR5
{
    interface IMoneyStrategy
    {
        void Add(decimal val);
        decimal GetSum();
        int GetAmount();
    }
}
