namespace DictionaryOrder_multicore.Logic.Interfaces
{
    public interface IFrequencyCalculator
    {
        List<KeyValuePair<string, int>> WordFrequencyCalculator(string[] words);
    }
}
