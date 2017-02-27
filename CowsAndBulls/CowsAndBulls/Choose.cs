using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    class Choose
    {
        static public Array Сonsequences()
        {
            //Choose
            Console.Write("Choose your enemy:\n1.Pc\t2.Friend");
            int Enemy = int.Parse(Console.ReadLine());
            //Сonsequences of choosing(последствия выбора)
            for (int i = 0; i < 0;)
            {
                //PC use random
                if (Enemy == 1)
                {
                    for (int a = 0; a < RightAnswer.Count; a++) ;
                    Random rnd = new Random();
                    int RightAnswer[];
                    return RightAnswer;
                }
                //User take number in array
                if (Enemy == 2)
                {
                    return RightAnswer;
                }
                //Catch wrong answer
                else Console.WriteLine("You need enter the number: ");
            }
           
        }
        static public int Attempt()
        {
            Console.Write("Enter attempts: ");
            int Attempt = int.Parse(Console.ReadLine());
            return Attempt;
        }
    }
}
