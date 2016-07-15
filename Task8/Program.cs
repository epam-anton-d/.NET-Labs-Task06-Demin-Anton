using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100000;
            string str = "";
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            // Получаем потраченное время на суммирование string.
            TimeSpan ts = stopWatch.Elapsed;
            
            // Вывод и форматирование времени.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("Время потраченное на сложение String: {0}", elapsedTime);

            Stopwatch stopWatch2 = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            stopWatch2.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine();
            stopWatch2.Stop();
            TimeSpan ts2 = stopWatch2.Elapsed;
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds);
            Console.WriteLine("Время потраченное на сложение StringBuilder: {0}", elapsedTime2);
            Console.WriteLine("\nВыгода использования класса StringBuilder при редактировании строки налицо.");
            Console.ReadKey();
        }
    }
}
