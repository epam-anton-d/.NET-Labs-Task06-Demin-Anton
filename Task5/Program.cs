using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[a-zA-Z0-9][a-zA-Z0-9\.\-_]*[a-zA-Z0-9]?@[a-zA-Z0-9][a-zA-Z0-9\-_]*[a-zA-Z0-9]?\.[a-zA-Z]{2,6}\b",
                   sentence;

            Console.Write("Введите строку: ");
            sentence = Console.ReadLine();
            Regex regex = new Regex(pattern);
            Console.WriteLine("\nНайденные адреса электронной почты: ");
            // Ищим и выводим соответствия шаблону.
            foreach (Match match in regex.Matches(sentence))
            {
                Console.WriteLine();
                Console.WriteLine(match.Value);
            }
            Console.ReadKey();
        }
    }
}
