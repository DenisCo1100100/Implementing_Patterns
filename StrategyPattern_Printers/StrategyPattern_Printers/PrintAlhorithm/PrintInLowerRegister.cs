namespace StrategyPattern_Printers.PrintAlhorithm
{
    public class PrintInLowerRegister : IStrategy
    {
        public string DoAlhorithm(string data) => data.ToLower();
    }
}