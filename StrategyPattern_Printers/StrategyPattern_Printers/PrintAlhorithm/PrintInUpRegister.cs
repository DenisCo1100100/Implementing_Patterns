namespace StrategyPattern_Printers.PrintAlhorithm
{
    public class PrintInUpRegister : IStrategy
    {
        public string DoAlhorithm(string data) => data.ToUpper();
    }
}