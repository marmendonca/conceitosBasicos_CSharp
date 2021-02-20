using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Nome;

        public double Preco;
        
        public int Quantidade;

        /* Sintaxe alternativa de iniciar valores sem os contrutores:
           Ex1: Produto p = new Produto {nome, preco, quantidade}
           Ex2: Produto p =  new Produto() {nome, preco, quantidade}
           OBS.: Posso usar essa alternativa tendo o construtor padrão.
         */

        //Construtor padrão
        public Produto()
        {
        }

        //Construtor com todos argumentos
        public Produto (string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Construtor com dois argumentos
        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
