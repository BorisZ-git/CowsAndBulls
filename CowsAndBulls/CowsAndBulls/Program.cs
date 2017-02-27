using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * Суть игры: ваш соперник, будь то компьютер или друг, загадывает 4-значное число,
 * состоящее из неповторяющихся цифр. Ваша задача - угадать его за ограниченное число ходов.
 * В качестве подсказок выступают “коровы” (цифра угадана, но её позиция - нет)
 * и “быки” (когда совпадает и цифра и её позиция).
 * То есть если загадано число “1234”, а вы называете “6531”, то результатом будет 
 * 1 корова (цифра “1”) и 1 бык (цифра “3”) .
 * Как усложнить: сохранение результатов, круговое соревнование на несколько игроков,
 * режим турнира, игра по сети.
*/

namespace CowsAndBulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello
            Console.Write("Introduce yourself: "); string PlayerName = Console.ReadLine();
            Console.WriteLine("You choose who will be your enemy: PC or friend." +
                "Your enemy wish a number like as 1234. You will have several attempts to answer right.");
            //Choose
            Console.Write("Choose your enemy:\n1.Pc\t2.Friend"); int Enemy = int.Parse(Console.ReadLine());
            Console.Write("Enter attempts: "); int Attempt = int.Parse(Console.ReadLine());
            //Сonsequences of choosing(последствия выбора)
            if (Enemy == 1) ;
            if (Enemy == 2) ;
            else Console.WriteLine("You need enter the number");
        }
    }
}
