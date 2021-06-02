using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Age
    {
        int age;
        public void Check()
        {
            Console.WriteLine("Enter a number");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);

        }
    }
}
