using System;

namespace PR5
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Context context = new Context();

            context.SetStrategy(new StrategyBill{ CBill = new Bill() });
            context.ExecuteAdd(100);
            context.ExecuteAdd(12);
            print.PrintOnScreen($"Сума - {context.ExecuteSum()}\nКількість - {context.ExecuteAmount()}\n");

            context.SetStrategy(new Strategy10Cent{ Cent10Coin = new Cent10Coin()});
            context.ExecuteAdd(10);
            print.PrintOnScreen($"Сума - {context.ExecuteSum()}\nКількість - {context.ExecuteAmount()}\n");

            context.SetStrategy(new Strategy5Cent { Cent5Coin = new Cent5Coin() });
            context.ExecuteAdd(5);
            context.ExecuteAdd(5);
            context.ExecuteAdd(5);
            print.PrintOnScreen($"Сума - {context.ExecuteSum()}\nКількість - {context.ExecuteAmount()}\n");
        }
    }
}
