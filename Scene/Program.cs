using System;

namespace Scene
{
    class Program
    {
        static void Main(string[] args)
        {
            string Line = "_____________";
            string Q = "-Как дела?";
            string A1 = "-Хорошо";
            string A2 = "-Плохо";
            scene(Line, Q, A1, A2);
        }
        static void jump()
        {
            
        }
        static void scene(params string[] asks)
        {
            const string space = "             ";
            for (int i = 0; i < asks.Length; i++)
            {
                Console.WriteLine(space + asks[i]);
            }

        }
    }
}
