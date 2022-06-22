using System;
using System.Collections.Generic;
using System.Text;

namespace PR5
{
    class Money
    {
        public List<decimal> Values { get; set; } = new List<decimal>();

        public void AddMoney(decimal val)
        {
            Values.Add(val);
        }

    }
}
