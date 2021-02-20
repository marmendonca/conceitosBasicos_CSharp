using System;

namespace funcoesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            
            //ToUpper coloca a string maiuscula, ToLower string minuscula, Trim recorta o espaço em branco.
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            //IndexOf informa a primeira posição da string e o LastOf a ultima.
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            //Substring recorta a string, nas sobrecargas posso informar a partir de qual e quantos caracteres desejo recortar.
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            //Replace substituo um caractere ou string pelo outro.
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            //IsNullOrEmpty testo se a string é nula ou vazia(Ex.: string nome = "") e IsNullOrWhiteSpace verifico se a string é nula
            //ou possui espaços em branco.
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
