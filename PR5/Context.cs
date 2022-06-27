using System;
using System.Collections.Generic;
using System.Text;

namespace PR5
{
    class Context
    {
        IMoneyStrategy _moneyStrategy;

        public void SetStrategy(IMoneyStrategy moneyStrategy)
        {
            _moneyStrategy = moneyStrategy;
        }

        public void ExecuteAdd(decimal val)
        {
            _moneyStrategy.Add(val);
        }

        public decimal ExecuteSum()
        {
            return _moneyStrategy.GetSum();
        }

        public void ExecuteAmount()
        {
            _moneyStrategy.GetAmount();
        }
    }
}
