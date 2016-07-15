using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(?([3])3[01]|[0-2]?[0-9])-(?([1])1[0-2]|0[0-9])-[1-2][0-9][0-9][0-9]",
                   sentence;

            Console.WriteLine("Введите предложение с датой в формате dd-mm-yyyy:");
            Console.WriteLine();
            sentence = Console.ReadLine();
            bool match = Regex.IsMatch(sentence, pattern);
            if (match)
            {
                Console.WriteLine("В тексте \"{0}\" содержится дата.", sentence);
            }
            else
            {
                Console.WriteLine("В тексте \"{0}\" не содержится дата.", sentence);
            }
            Console.ReadKey();
        }
    }
}
