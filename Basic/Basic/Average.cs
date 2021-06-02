using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Average
    {
        double num1;
        double num2;
        double num3;
        double num4;
        double output;
        public void Check()
        {
            Console.WriteLine("Enter the num1 valu");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2 Value");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num3 value");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num4 value");
            num4 = Convert.ToDouble(Console.ReadLine());
            output = num1 + num2 + num3 + num4 / 4;
            Console.WriteLine("average of four numbers is" + output);

        }
    }
}
