using System;
using System.Collections.Generic;

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
        public static void choose(params Action[] scenes)
        {
            
            Dictionary<ConsoleKey, Action> keys = new Dictionary<ConsoleKey, Action>
            {
                { ConsoleKey.D1, scenes[0] },
                {ConsoleKey.D2, scenes[1] },
                {ConsoleKey.D3, scenes[2] },
                {ConsoleKey.D4, scenes[3] }
            };
            var key = Console.ReadKey();
            Action action;

            if (keys.TryGetValue(key.Key, out action))
            {
                action();
            }

        }
        public static void choose1(params Action[] scenes)
        {

            var dictionary = new Dictionary<Int32, Action>();
            var iter = 0;
            foreach (var scene in scenes)
            {
                dictionary[iter] = scene;
                iter++;
            }
            var key = Int32.Parse(Console.ReadLine());
            foreach (KeyValuePair<Int32, Action> kvp in dictionary)
            {
                if (key == iter)
                {
                    kvp.Value();
                }

            }

        }
        //static void scene4()
        //{
        //    jump();
        //    q = "вова позавтракал. на часах 7:30." +
        //     space +
        //     "на чем вова будете добираться до школы?";
        //    a1 = "-на автобусе(займет 30 минут)";
        //    a2 = "-пешком(займет час)";
        //    a3 = "-на велосипеде(займет 10 минут)";
        //    scene(line, q, a1, a2, a3);
        //}
        //static void scene8()
        //{
        //    jump();
        //    Q = "Вова решил поехать на автобусе и приехал ровно в 8:00. Поздравляю! вова успели в школу";
        //    scene(Line, Q);
        //}
        //static void scene9()
        //{
        //    jump();
        //    Q = "вова решил пойти пешком и опоздал в школу на полчаса. к сожалениию, вова опоздали, завтра вове придется встать пораньше. ";
        //    scene(Line, Q);
        //}
        //static void scene10()
        //{
        //    jump();
        //    Q = "вова решил поехать на велосипеде и успел в школу. оздравляю! вова успели в школу";
        //    scene(Line, Q);
        //}

    }
}
