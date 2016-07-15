using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "",
                    answer;
            const string example = "Если вас интересует мое мнение - я выскажусь: настоящая дружба (именно дружба, а не шапочное знакомство или приятельские отношения) проверяется в радости; умение разделить радость другого человека - этим сегодня могут похвастаться немногие, очень немногие друзья!";
            char[] separator = new char[] { ' ', '!', '?', ':', ',', '.', '-', ';', '(', ')' };

            // Пользовательский ввод.
            Console.WriteLine("Хотите ввести свой текст (наберите [y/Y]) или использовать пример?(наберите [n/N])");
            answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Console.WriteLine("Введите текст: \n");
                sentence = Console.ReadLine();
            }
            else if (answer == "n")
            {
                Console.WriteLine("Пример: \n");
                sentence = example;
                Console.WriteLine(sentence);
            }
            else
            {
                Console.WriteLine("Не правильный ввод, будет использован пример");
                sentence = example;
                Console.WriteLine(sentence);
            }

            // Разбиваем предложение на слова.
            string[] elements = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            // Считаем общее колличество букв.
            for (int i = 0; i < elements.Length; i++)
            {
                //Console.WriteLine(elements[i]);
                count += elements[i].Length;
            }
            // Вычисляем среднее арифметическое букв в слове.
            double middle = (double) count / elements.Length;
            Console.WriteLine();
            Console.WriteLine("Средняя длина слов в предложении = {0}", middle);
            Console.ReadKey();
        }
    }
}
