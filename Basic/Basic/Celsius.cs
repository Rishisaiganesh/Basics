using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Celsius
    {
        int celsius;
        int kelvin;
        int Fahrenheit;

        public void check()
        {
            Console.WriteLine("Enter the ammount of celsius");
            celsius = Convert.ToInt32(Console.ReadLine());
            int kelvin = celsius + 275;
            int Fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("kelvin position"+ kelvin);
            Console.WriteLine("Fahrenheit"+ Fahrenheit);

        }
    }
}
