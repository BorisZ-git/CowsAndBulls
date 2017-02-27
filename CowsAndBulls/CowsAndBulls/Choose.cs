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
                    for (int a = 0; a < RightAnswer.Length; a++) RightAnswer[a] = rnd.Next(0, 9);
                    break;
                }
                //User take number in array
                if (Enemy == 2)
                {
                    /*user enter number like string(string it's array) and after this
                     method record elements of string in converted to string array RightAnswer
                     and after this method return converted back in int RightAnswer
                     1.Add check on more and less then four elemetns
                     2.Add check on char like b a c % ! and other
                     3.Realize alternate record of variables*/
                    Console.Write("Enter your number: ");
                    string Number = Console.ReadLine();
                    RightAnswer = Number.Select(digit => int.Parse(digit.ToString())).ToArray();
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
        //static int UserNumber(string number, int i)
        //{
            
        //    //Array.ConvertAll(number.Split(), int.Parse);
        //    int UserNumber = int.Parse(number[i]);
        //    return UserNumber;

        //}
    }
}
