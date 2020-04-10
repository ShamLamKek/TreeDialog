using System;
using System.Threading;

namespace ConsoleApplication8
{

    class Program
    {

        public static string Line = "_____________";
        public static string Q;
        public static string A1;
        public static string A2;
        public static string A3;
        public static string A4;
        public static string A5;
        public static string A6;
        public static string A8; 
        public static string A9;
        public static void Main()

        {
            scenemain();
            choose(scene1, scene2);

        }    


        static void scenemain()
        { 
            Q = "-Как дела?";
            A1 = "-Хорошо"; 
            A2 = "-Плохо";
            scene(Line, Q, A1, A2);
        }
        static void scene1()
        {
            jump("-Печально");
            Q = "Что случилось?";
            A1 = "-Неважно";
            A2 = "-Да так";
            scene(Line, Q, A1, A2);
        }
        static void scene2()
        {
            jump("-здорово!");
            Q = "Я рад!";
            A1 = "-Пока";
            A2 = "-Пока!!!!!";
            scene(Line, Q, A1, A2);
        }


        public static void jump(string output)
        {
            Console.WriteLine(output);
            Thread.Sleep(1500);
            Console.Clear();
        }
        public static void scene(params string[] asks)

        {
            const string space = "             ";
            for (int i = 0; i < asks.Length; i++)
            {
                Console.WriteLine(space + asks[i]);
            }
        }
        public static void choose(params Action[] scenes)
        {
            ConsoleKey key = Console.ReadKey().Key;
            if (key== ConsoleKey.D1)
            {
                scenes[0]();
            }
            
            if (key == ConsoleKey.D2)
            {
                scenes[1]();
            }
            if (key == ConsoleKey.D3)
            {
                scenes[2]();
            }
            if (key == ConsoleKey.D3)
            {
                scenes[2]();
            }
            if (key == ConsoleKey.D4)
            {
                scenes[3]();
            }
            if (key == ConsoleKey.D5)
            {
                scenes[4]();
            }
            if (key == ConsoleKey.D6)
            {
                scenes[5]();
            }
            if (key == ConsoleKey.D7)
            {
                scenes[6]();
            }
            if (key == ConsoleKey.D8)
            {
                scenes[7]();
            }
            if (key == ConsoleKey.D9)
            {
                scenes[8]();
            }

        }
        
    }
}

