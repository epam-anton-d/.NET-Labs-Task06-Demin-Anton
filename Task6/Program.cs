using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            string patternOrdinary = @"\A[\-]?[0-9]+(\.[0-9]+)?\Z";
            string patternScience = @"\A[\-]?[0-9]\.[0-9]+e[\+\-][0-9]+\Z";

            Console.Write("Введите число: ");
            sentence = Console.ReadLine();
            Regex regex = new Regex(patternOrdinary);
            Match match = regex.Match(sentence);
            // Ищим совпадения с шаблоном.
            if (match.Success)
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else
            {
                regex = new Regex(patternScience);
                match = regex.Match(sentence);
                if (match.Success)
                {
                    Console.WriteLine("Это число в научной нотации", match.Value);
                }
                else
                {
                    Console.WriteLine("Это не число");
                }
            }
            Console.ReadKey();
        }
    }
}
