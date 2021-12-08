using System;

namespace AdapterPattern
{
    class Adapter : ITextProcessor
    {
        public readonly WordCounter WordCounter;

        public Adapter(WordCounter wordCounter) => WordCounter = wordCounter;

        public void ProcessTest(string text)
        {
            WordCounter.InputText(text);

            foreach (var word in WordCounter.GetWordsByDecreasingFrequency())
            {
                Console.WriteLine($"{word} => {WordCounter.GetCount(word)}");
            }
        }
    }
}
