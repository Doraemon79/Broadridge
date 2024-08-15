using System.Collections.Concurrent;

namespace DictionaryOrder_multicore.Logic.Interfaces
{
    public interface IHelper
    {
        string[] SplitWords(string text);
        void FlushOutput(ConcurrentDictionary<string, int> wordsbyFrequecy);
    }
}
