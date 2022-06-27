using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PR5
{
    class Bill : Money
    {
        public Dictionary<decimal, List<decimal>> ConcreteBill()
        {
            return Values.GroupBy(x => x).ToDictionary(x => x.Key, x => x.ToList());
        }
    }
}
