using System;
using System.Globalization;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de entrada de produtos: ");
            int n = int.Parse(Console.ReadLine());

            //Declaração de um vetor do tipo referencia.
            Product[] prod = new Product[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Adicionado valores em um vetor do tipo referencia
                prod[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                //Pegando valores de um vetor do tipo referencia
                sum += prod[i].Price;
            }

            double media = sum / n;
            Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
