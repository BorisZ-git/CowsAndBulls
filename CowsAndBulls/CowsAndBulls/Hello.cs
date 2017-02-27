using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    class Hello
    {
        static public void Rule()
        {
            Console.WriteLine("You choose who will be your enemy: PC or friend.\n" );
            Console.Write("Your enemy wish a number like as 1234.\n");
            Console.Write("You will have several attempts to answer right.\n");
            Console.Write("When you will guess right number, but not position. You'll take a cow\n");
            Console.Write("When you will guess position, but not a number. You'll take a bull\n");
            Console.Write("So if enemy wish number 1234, and your answer 1567. You have 1 cow and 1 bull");
        }

    }
}
