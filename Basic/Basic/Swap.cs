using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Swap
    {
        int num1;
        int num2;
        int i;
        public void main()
        {
            Console.WriteLine("Give first number");
            num1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Give second Number");
            num2 = Int16.Parse(Console.ReadLine());
            i = num1;
            num1 = num2;
            num2 = i;
            Console.WriteLine("After swaping");
            Console.WriteLine("first number after swaping" + num1);
            Console.WriteLine("Second number after Swaping" + num2);
            

        }
    }
}
