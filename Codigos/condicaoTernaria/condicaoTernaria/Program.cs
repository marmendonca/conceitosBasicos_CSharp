using System;
using System.Globalization;

namespace condicaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição.
            //Sintaxe: (condição) ? valor_se_verdadeiro : valor_se_falso
            //Ex.:

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco > 20.0) ? preco * 0.05 : preco * 0.1;

            Console.WriteLine(desconto);




        }
    }
}
