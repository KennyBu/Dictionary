using System.Collections.Generic;
using System.Linq;

namespace DictionaryConsole
{
    public class DictionarySearcher : IDictionarySearcher
    {
        private readonly string[] _dictionary;
        private List<string> _wordsFound;
        
        public DictionarySearcher(string[] dictionary)
        {
            _dictionary = dictionary;
            _wordsFound = new List<string>();
        }

        public IEnumerable<string> Search(string input, Enums.SearchType searchType)
        {
            if (searchType == Enums.SearchType.Linq)
            {
                SearchWithLinq(input);    
            }
            else
            {
                SearchWithoutLinq(input);    
            }

            return _wordsFound;
        }

        private void SearchWithLinq(string input)
        {
            _wordsFound = _dictionary.Where(input.Contains).ToList();
        }

        private void SearchWithoutLinq(string input)
        {
            foreach (var word in _dictionary)
            {
                if (input.Contains(word))
                {
                    _wordsFound.Add(word);
                }
            }
        }
    }
}