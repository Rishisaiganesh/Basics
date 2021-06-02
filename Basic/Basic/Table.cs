using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Table
    {
        int x;
        int num;
        public void table()
        {
            Console.WriteLine("Enter a number");
            x = Convert.ToInt16(Console.ReadLine());
            num = x * 1;
            Console.WriteLine( num);
            num = x * 2;
            Console.WriteLine(num);
            num = x * 3;
            Console.WriteLine(num);
            num = x * 4;
            Console.WriteLine(num);
            num = x * 5;
            Console.WriteLine(num);
            num = x * 6;
            Console.WriteLine(num);
            num = x * 7;
            Console.WriteLine(num);
            num = x * 8;
            Console.WriteLine(num);
            num = x * 9;
            Console.WriteLine(num);
            num = x * 10;
            Console.WriteLine(num);


        }
    }
}
