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
            Hello.Rule();
            //Choose and take number and take value of attempts
            int[] RightAnswer = Choose.Сonsequences();
            int attempts = Choose.Attempt();
            //inspection(Check work or not)
            for (int a = 0; a < RightAnswer.Length;a++)
            {
                Console.Write(RightAnswer[a]);
            }
            Console.ReadLine();

        }
    }
}
