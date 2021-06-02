using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("press 0 to Name");
            Console.WriteLine("Press 1 to Addition");
            Console.WriteLine("Press 2 to division");
            Console.WriteLine("Press 3 to Arthamatic");
            Console.WriteLine("Press 4 to Swaping");
            Console.WriteLine("Press 5 to Multilication");
            Console.WriteLine("Press 6 to AddMulSub by user");
            Console.WriteLine("Press 7 to Table");
            Console.WriteLine("Press 8 to Average");
            Console.WriteLine("Press 9 to multiplication with 3 users number");
            Console.WriteLine("press 10 to check age");
            int selectio = Convert.ToInt32(Console.ReadLine());
            switch (selectio)
            {

                case 0: 
                  basic OBj = new basic();
                  OBj.Name();
                  break;
                case 1:
                  Adding add = new Adding();
                  add.sum();
                  break;
                case 2:
                  Division div = new Division();
                  div.Div();
                  break;
                case 3:
                  Arthamatic art = new Arthamatic();
                  art.add();
                  break;
                case 4:
                  Swap swap = new Swap();
                  swap.main();
                    break;
                case 5:
                  Multiplication bj = new Multiplication();
                  bj.Mul();
                    break;
                case 6:
                    AddSubMul Obj = new AddSubMul();
                    Obj.Add();
                    break;
                case 7:
                    Table obj = new Table();
                    obj.table();
                    break;
                case 8:
                    Average avg = new Average();
                    avg.Check();
                    break;
                case 9:
                    MultiplayWith3inputs mul = new MultiplayWith3inputs();
                    mul.add();
                    break;
                case 10:
                    Age check = new Age();
                    check.Check();
                    break;
                default:
                    Console.WriteLine("in valid expresion");
                    break;


        }
        }
    }
}
