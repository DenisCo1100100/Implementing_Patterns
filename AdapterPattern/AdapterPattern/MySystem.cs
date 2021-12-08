using System.Text;

namespace AdapterPattern
{
    class MySystem
    {
        public string Text { get; }

        public MySystem(string text) => Text = RemoveSpecialChar(text);

        public void GetProcessedText(ITextProcessor processor) => processor.ProcessTest(Text);

        private static string RemoveSpecialChar(string text)
        {
            var stringBuilder = new StringBuilder(text);

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (!char.IsNumber(stringBuilder[i]) && !char.IsLetter(stringBuilder[i]))
                {
                    stringBuilder.Replace(stringBuilder[i], ' ');
                }
            }

            return stringBuilder.ToString();
        }
    }
}