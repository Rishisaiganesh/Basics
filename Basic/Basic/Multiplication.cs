using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Multiplication
    {
        int num1;
        int num2;
        int num3;
        public void Mul()
        {
            Console.WriteLine("Enter first num");
            num1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num");
            num2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter third num");
            num3 = Int16.Parse(Console.ReadLine());
            int Result = num1 * num2 * num3;
            Console.WriteLine(Result);


        }
    }
}
