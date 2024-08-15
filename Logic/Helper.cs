using DictionaryOrder_multicore.Logic.Interfaces;
using System.Collections.Concurrent;

namespace DictionaryOrder_multicore.Logic
{
    public class Helper : IHelper
    {
        public string[] SplitWords(string text)
        {
            var words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); //what is new line in windows-1252??
            return words;
        }

        public void FlushOutput(ConcurrentDictionary<string, int> wordsbyFrequecy)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = Path.Combine(docPath, "Broadridge.txt");
            using (StreamWriter writer = new StreamWriter(docPath))
            {
                foreach (var word in wordsbyFrequecy)
                {
                    writer.WriteLine($"{word.Key},{word.Value}\n");
                }
            }

        }
    }
}