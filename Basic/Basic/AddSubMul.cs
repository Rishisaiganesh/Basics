using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class AddSubMul
    {
        int num1;
        int num2;
        public void Add()
        {
            Console.WriteLine("give input to num1");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give input to num2");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Adding two numbers" + num1 + num2);
            Console.WriteLine("Subracting Two Numbers"+   num1,-num2);
            Console.WriteLine("Multiplication Two Numbers" + num1 * num2);
            Console.WriteLine("Dividing Two numbers" + num1 / num2);

        }
    }
}
