using System;

namespace StrategyPattern_Printers
{
    class Program
    {
        static void Main()
        {
            IStrategy[] printOptions = new IStrategy[]
            {
                new PrintAlhorithm.PrintInOneLine(),
                new PrintAlhorithm.PrintInUpRegister(),
                new PrintAlhorithm.PrintInLowerRegister()
            };

            var printer = new Printer();
            string inputStr = "Hellow\nWorld, I like you!";
            Console.WriteLine($"Input string:\n{inputStr}\n");

            foreach (var options in printOptions)
            {
                printer.Strategy = options;
                printer.ExecuteCommand($"Hellow\nWorld, I like you!");
            }

        }
    }
}