namespace StrategyPattern_Printers.PrintAlhorithm
{
    public class PrintInOneLine : IStrategy
    {
        public string DoAlhorithm(string data) => data.Replace('\n', ' ');
    }
}