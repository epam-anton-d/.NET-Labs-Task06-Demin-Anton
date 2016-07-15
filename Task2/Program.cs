using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "написать программу, которая",
                   compareString = "описание",
                   outputString = "",
                   answer;

            // Пользовательский ввод.
            Console.WriteLine("Хотите ввести свой текст (наберите [y/Y]) или использовать пример?(наберите [n/N])");
            answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Console.WriteLine("Введите первую строку: ");
                inputString = Console.ReadLine();
                Console.WriteLine("Введите вторую строку: ");
                compareString = Console.ReadLine();
            }
            else if (answer == "n")
            {
                Console.WriteLine("\nПример: \n");
                Console.WriteLine("Первая строка: \n{0}", inputString);
                Console.WriteLine("Вторая строка: \n{0}", compareString);
            }
            else
            {
                Console.WriteLine("Не правильный ввод, будет использован пример");
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                outputString += inputString[i];
                for (int j = 0; j < compareString.Length; j++)
                {
                    // Сравниваем строки побуквенно, если есть совпадения выводим букву дважды.
                    if (Equals(inputString[i], compareString[j]))
                    {
                        outputString += inputString[i];
                        break;
                    }
                }
            }

            Console.WriteLine("Результат:");
            Console.WriteLine(outputString);
            Console.ReadKey();
        }
    }
}
