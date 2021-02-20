using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando listas vazias
            List<string> list1 = new List<string>();

            //Declarando listas e inicando com valores
            List<string> list2 = new List<string>() { "Maria", "João", "Chico" };

            //Declarando listas e usando seus valores
            List<string> nomes = new List<string>();

            //Add adiciona valores do tipo da sua lista
            nomes.Add("Maria");
            nomes.Add("Alex");
            nomes.Add("Jão");
            nomes.Add("Bob");
            nomes.Add("Ana");
            //insert adiciona tb valores só que é possível informar uma posição
            nomes.Insert(4, "Mariza");

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            //Count conta a quantidade posições da lista
            Console.WriteLine("List count " + nomes.Count);

            //Find encontra o primeiro valor de acordo com o valor que você passa na expressão lambda
            string s1 = nomes.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //FindLast encontra o último valor de acordo com o valor que você passa na expressão lambda
            string s2 = nomes.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //FindIndex encontra a primeira posição de acordo com o valor que você passa na expressão lambda
            int pos1 = nomes.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //FindLastIndex encontra a última posição de acordo com o valor que você passa na expressão lambda
            int pos2 = nomes.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //FindAll encontra todo mundo de acordo com o valor que você passa na expressão lambda, nesse caso
            //estou verificando de acordo com o tamanho do nome.
            //Para isso pode-se criar uma lista auxiliar para guardar o resultado.
            List<string> list = nomes.FindAll(x => x.Length == 5);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------------------------------");

            //Remove exclui o valor que voce passa
            nomes.Remove("Alex");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            //RemoveRange exclui uma determinada quantidade de valores passando posição e quantidade.
            nomes.RemoveRange(2, 1);
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            //RemoveAll exclui todos de acordo com o valor que voce passa
            nomes.RemoveAll(x => x[0] == 'M');
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
