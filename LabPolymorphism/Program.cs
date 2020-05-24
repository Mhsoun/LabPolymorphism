using System;


namespace MathOperation
{
    class Program
    {
        static void Main()
        {
            MathOperation mo = new MathOperation();

            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

            Console.ReadLine();
        }
    }
}