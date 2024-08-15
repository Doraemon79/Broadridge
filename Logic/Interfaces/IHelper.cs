namespace DictionaryOrder_multicore.Logic.Interfaces
{
    public interface IHelper
    {
        string[] SplitWords(string text);
        void FlushOutput(List<KeyValuePair<string, int>> wordsbyFrequecy);
    }
}
