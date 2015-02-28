using System;
using System.Linq;

namespace DictionaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultPath = "StartBurst";
            
            try
            {
                var input = args.Length == 0 ? defaultPath : args[0];

                var dictionary = InitializeDictionary();

                var searcher = new DictionarySearcher(dictionary);

                var results = searcher.Search(input, Enums.SearchType.Linq);

                if (!results.Any())
                {
                    Console.WriteLine("I'm sorry no words were found.");
                }

                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("An Error Occurred: {0}", exception.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit...");
            Console.Read();
        }

        private static string[] InitializeDictionary()
        {
            var dictionary = new string[]
            {
                "Star",
                "Burst",
                "Car",
                "House",
                "Programming",
                "Test"
            };

            return dictionary;
        }
    }
}
