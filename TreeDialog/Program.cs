using System;
using System.Threading;

namespace ConsoleApplication8
{

    class Program
    {
        public static void Main()

        {
            Face();
            Console.WriteLine("{0,51}", "_______________________");
            Console.WriteLine("{0,45}", "Привет!Как дела?:");
            string A1 = "-Привет!Все плохо:(";
            string A2 = "-Привет!Все хорошо:)";
            Console.WriteLine("{0,47}", A1);
            Console.WriteLine("{0,48}", A2);
            Console.SetCursorPosition(30, 10);
            Console.WindowHeight = 20;
            Console.WindowWidth = 70;
            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1)
            {
                Console.WriteLine("-Печально");
                Thread.Sleep(2000);
                Console.Clear();
                Face();
                Console.WriteLine("{0,51}", "_______________________");
                Console.WriteLine("{0,42}", "Что случилось?");
                string B1 = "-Неважно";
                string B2 = "-Да так";
                Console.WriteLine("{0,37}", B1);
                Console.WriteLine("{0,37}", B2);
            }
            else if (key == ConsoleKey.D2)
            {
                Console.WriteLine("-Здорово");
                Thread.Sleep(2000);
                Console.Clear();
                Face();
                Console.WriteLine("{0,51}", "_______________________");
                Console.WriteLine("{0,50 }", "Расскажешь что-нибудь?");
                string B1 = "-Да";
                string B2 = "-Нет";
                Console.WriteLine("{0,31}", B1);
                Console.WriteLine("{0,32}", B2);
            }

            else if (key == ConsoleKey.D3)
            {
                Console.WriteLine("-Вы продолжили свой путь.");
            }
            

            static void Face()
            {
                Console.WriteLine("     __   __ ");
                Console.WriteLine("    /()| /()|");
                Console.WriteLine("       /|");
                Console.WriteLine("      .... ");
            }
        }

    }
}
