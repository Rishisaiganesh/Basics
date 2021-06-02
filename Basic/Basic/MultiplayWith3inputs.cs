using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class MultiplayWith3inputs
    {
        double num1;
        double num2;
        double num3;
        public void add()
        {
            Console.WriteLine("give  num1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("give num2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give num3");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((num1 = num2) * num3);
            Console.WriteLine(num1 * num2 + num2 * num3);
            
        }
    }
}
