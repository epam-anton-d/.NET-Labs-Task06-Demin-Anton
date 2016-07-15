using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            string pattern = @"\b(?([2])2[0-3]|1?[0-9])\:[0-5][0-9]\b";
            int count = 0;

            Console.Write("Введите текст: ");
            sentence = Console.ReadLine();
            Regex regex = new Regex(pattern);
            // Поиск и подсчет совпадений шаблона.
            foreach (Match match in regex.Matches(sentence))
            {
                if (match.Success)
	            {
	            	 count++;
	            }
            }
            Console.WriteLine("\nВремя в тексте присутствует {0} раз(а).", count);
            Console.ReadKey();
        }
    }
}
