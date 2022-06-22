using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PR5
{
    class Bill : Money
    {
        public decimal GetSum()
        {
            return Values.Sum();
        }
    }
}
