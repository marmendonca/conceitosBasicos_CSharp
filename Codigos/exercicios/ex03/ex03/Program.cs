using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> func = new List<Funcionarios>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Add(new Funcionarios(id, name, sal));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int num = int.Parse(Console.ReadLine());

            Funcionarios f = func.Find(x => x.Id == num);
            if (f != null)
            {
                Console.Write("Enter the percentage: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.Aumento(porcent);
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionarios obj in func)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
