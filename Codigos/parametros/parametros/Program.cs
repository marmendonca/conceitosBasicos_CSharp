using System;

namespace parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //passando valor com o params
            int n = Calculator.Sum(2, 4);
            Console.Write(n);
        }
    }
}
