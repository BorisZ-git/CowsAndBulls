using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    class Choose
    {
        static public int[] Сonsequences()
        {
            //Choose
            Console.Write("Choose your enemy:\n1.Pc\t2.Friend\n");
            int Enemy = int.Parse(Console.ReadLine());
            //Create variable for number
            int[] RightAnswer = new int[4];
            Random rnd = new Random();

            //Сonsequences of choosing(последствия выбора)
            while (true)
            {
                //PC use random
                if (Enemy == 1)
                {
                    for (int a = 0; a < RightAnswer.Length; a++)
                    {
                        RightAnswer[a] = rnd.Next(0, 9);
                    }
                    break;
                }
                //User take number in array
                if (Enemy == 2)
                {
                    for (int a = 0; a < RightAnswer.Length; a++)
                    {
                        Console.WriteLine("Enter your number: ");
                        RightAnswer[a] = int.Parse(Console.ReadLine());//i wanna user enter full number
                    }
                    break;
                }
                //Catch wrong answer
                else Console.WriteLine("You need enter the number: ");
            }
            return RightAnswer;

        }
        static public int Attempt()
        {
            Console.Write("Enter attempts: ");
            int Attempt = int.Parse(Console.ReadLine());
            return Attempt;
        }
    }
}
