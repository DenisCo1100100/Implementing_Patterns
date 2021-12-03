using System;

namespace StrategyPattern_Printers
{
    public class Printer
    {
        public IStrategy Strategy { set { _strategy = value; }  }

        private IStrategy _strategy;

        public Printer() { }

        public Printer(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteCommand(string data)
        {
            string resultStr = _strategy.DoAlhorithm(data);
            Console.WriteLine($"\n{_strategy.GetType().Name} result:\n{resultStr}");
        }
    }
}