using System;

namespace modificadorRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //com o medificador ref voce faz a referencia de uma variavel a outra, assim como o metodo é void
            //vai poder retornar o que foi mudado no metodo estatico.
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
