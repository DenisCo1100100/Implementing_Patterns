using System.Linq;

namespace AdapterPattern
{
    class WordCounter
    {
        public string Text { get; private set; }
        private string[] _words;

        public void InputText(string text)
        {
            Text = text;
            _words = text.Split(' ');
        }

        public int CountWords() => _words.Length - 1;

        public int GetCount(string word)
        {
            int counter = 0;

            for (int i = 0; i < _words.Length; i++)
            {
                if (_words[i] == word)
                {
                    counter++;
                }
            }

            return counter;
        }

        public string[] GetAllWords() => _words;

        public string[] GetWordsByDecreasingFrequency()
        {
            var words = GetAllWords();
            var countWords = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                countWords[i] = GetCount(words[i]);
            }

            DubleBubleSort(countWords, words);

            return words.Distinct().ToArray();
        }

        private static void DubleBubleSort(int[] countWords, string[] words)
        {
            int tempInt;
            string tempStr;

            for (int i = 0; i < countWords.Length - 1; i++)
            {
                for (int j = 0; j < countWords.Length - i - 1; j++)
                {
                    if (countWords[j + 1] > countWords[j])
                    {
                        tempInt = countWords[j + 1];
                        countWords[j + 1] = countWords[j];
                        countWords[j] = tempInt;

                        tempStr = words[j + 1];
                        words[j + 1] = words[j];
                        words[j] = tempStr;
                    }
                }
            }
        }
    }
}
