using System.Collections.Concurrent;

namespace DictionaryOrder_multicore.Logic.Interfaces
{
    public interface IFrequencyCalculator
    {
        ConcurrentDictionary<string, int> WordFrequencyCalculator(string[] words);
    }
}
