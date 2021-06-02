using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class DisplayInputsFourtimes
    {
        int num;
        public void check()
        {
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(num);
            Console.Write("");
            Console.Write(num);
            Console.Write("");
            Console.Write(num);
            Console.Write("");
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine(num);
            Console.WriteLine(num);
            Console.WriteLine(num);
            Console.Write( ""+ num, num, num, num);
        }
    }
}
