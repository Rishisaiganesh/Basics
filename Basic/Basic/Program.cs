using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic programs");
            basic OBj = new basic();
            OBj.Name();
            Adding add = new Adding();
            add.sum();
            Division div = new Division();
            div.Div();
            Arthamatic art = new Arthamatic();
            art.add();
            Swap swap = new Swap();
            swap.main();


        }
    }
}
