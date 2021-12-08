namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySystem = new MySystem("qwe qwe qwe qw eeee ss ss ss ss,rrr r rr xx xx x x");
            mySystem.GetProcessedText(new Adapter(new WordCounter()));
        }
    }
}
