using System;

namespace arraySimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de declaração de vetores.
            double[] num = new double[/*aqui informa o tamanho do vetor*/ 3];
            //exemplo de adicionar valores ao mesmo
            num[0] = 1;
            num[1] = 2;


            //Declarando vetores e já adicionando valores a ele.
            string[] vet = new string[2]
            {
                "maria",
                "joana"
            };

            int n = 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
