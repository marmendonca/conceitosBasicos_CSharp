using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudant[] estudant = new Estudant[10];

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("#" + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                estudant[room] = new Estudant(name, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudant[i] != null)
                {
                    Console.WriteLine(i + ": " + estudant[i]);
                }
            }
        }
    }
}
