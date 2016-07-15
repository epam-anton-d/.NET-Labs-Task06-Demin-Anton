using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        const string replaceWord = "_";
        static void Main(string[] args)
        {
            string pattern = @"<.\w*>"; // Шаблон "<.*>" почемуто не работает
            string sentence;
            Console.Write("Введите HTML текст: ");
            sentence = Console.ReadLine();
            sentence = Regex.Replace(sentence, pattern, replaceWord);
            Console.WriteLine();
            Console.Write("Результат замены: {0}", sentence);
            Console.ReadKey();
        }
    }
}
