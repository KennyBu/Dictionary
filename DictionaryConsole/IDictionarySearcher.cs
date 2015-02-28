using System.Collections.Generic;

namespace DictionaryConsole
{
    public interface IDictionarySearcher
    {
        IEnumerable<string> Search(string input, Enums.SearchType searchType);
    }
}