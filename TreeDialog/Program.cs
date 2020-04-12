using System;
using System.Collections.Generic;
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
        public static Action action;

        public static void Main()

        {
            scenemain();
            choose(scene1, scene2, scene4);
            if (action == scene1)
            {
                choose(scene6, scene5);
                if (action == scene5)
                {
                    choose(scene6);
                }
                choose(scene7);
                choose(scene8, scene9, scene10);
            }
            else if (action == scene2)
            {
                choose(scene11, scene7, scene7, scene4);
                if (action == scene11)
                {
                    choose(scene12, scene13, scene10);
                }
                else if (action == scene7)
                {
                    choose(scene8, scene9, scene10);
                }
            }
        }


        static void scenemain()
        {
            Q = "Вова школьник и каждый день он ходит в школу к 8:00. Вова просыпается и..  ";
            A1 = "-Сразу же встает.";
            A2 = "-Решает полежать еще полчасик.";
            A3 = "-Решает спать дальше и никуда не идти.";
            scene(Line, Q, A1, A2, A3);
        }
        static void scene1()
        {
            jump();
            Q = "Вова встал. Что дальше?";
            A1 = "-Вова идет умываться.";
            A2 = "-Вова идет завтракать.";
            scene(Line, Q, A1, A2);
            
        }
        static void scene2()
        {
            jump();
            Q = "Вова полежал полчасика и его время ограничено. Что дальше?";
            A1 = "-Вова встает, умывается и идет завтракать.";
            A2 = "-Вова встает, умывается, но не идет завтракать.";
            A3 = "-Вова встает, завтракает, но не идет умываться.";
            A4 = "-Вова решает спать дальше.";
            scene(Line, Q, A1, A2,A3, A4);

        }
        static void scene3()
        {
            jump();
            Q = "Вова полежал часик. Что дальше?";
            A1 = "-Вова встает.";
            A2 = "-Вова решает спать дальше.";
            scene(Line, Q, A1, A2);
        }
        static void scene4()
        {
            jump();
            Q = "Вова решает спать дальше. Вова проспал все уроки.";
            scene(Line, Q);
        }

        static void scene5()
        {
            jump();
            Q = "Вова решил пойти завтракать.Но мама сказала сначала пойти умыться.";
            A1 = "-Вова идет умываться.";
            scene(Line, Q, A1);
        }
        static void scene6()
        {
            jump();
            Q = "Вова умылся, теперь можно и позавтракать.";
            A1 = "-Завтракать";
            scene(Line, Q, A1);
        }
        static void scene7()
        {
            jump();
            Q = "Вова позавтракал. На часах 7:30. На чем Вова будете добираться до школы?";
            A1 = "-На автобусе(займет 30 минут)";
            A2 = "-Пешком(займет час)";
            A3 = "-На велосипеде(займет 10 минут)";
            scene(Line, Q, A1, A2, A3);
        }
        static void scene8()
        {
            jump();
            Q = "Вова решил поехать на автобусе и приехал ровно в 8:00. Поздравляю! Вова успели в школу";
            scene(Line, Q);
        }
        static void scene9()
        {
            jump();
            Q = "Вова решил пойти пешком и опоздал в школу на полчаса. К сожалениию, Вова опоздали, завтра Вове придется встать пораньше. ";
            scene(Line, Q);
        }
        static void scene10()
        {
            jump();
            Q = "Вова решил поехать на велосипеде и успел в школу. Поздравляю! Вова успели в школу";
            scene(Line, Q);
        }
        static void scene11()
        {
            jump();
            Q = "Вова позавтракал и умылся. На часах 7:45. На чем Вова будете добираться до школы?";
            A1 = "-На автобусе(займет 30 минут)";
            A2 = "-Пешком(займет час)";
            A3 = "-На велосипеде(займет 10 минут)";
            scene(Line, Q, A1, A2, A3);
        }
        static void scene12()
        {
            jump();
            Q = "Вова решил поехать на автобусе и опоздал в школу. К сожалениию, вова опоздали, завтра вове придется встать пораньше.";
            scene(Line, Q);
        }
        static void scene13()
        {
            jump();
            Q = "Вова решил пойти пешком и опоздал в школу. К сожалениию, вова опоздали, завтра вове придется встать пораньше. ";
            scene(Line, Q);
        }



        public static void jump()
        {
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
            var key = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < scenes.Length; i++)
            {
                if (key == i + 1 )
                {
                    action = scenes[i];
                    scenes[i]();
                    break;
                }
                    
                
            }
        }     
    }
}

