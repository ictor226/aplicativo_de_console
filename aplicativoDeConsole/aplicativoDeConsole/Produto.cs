namespace aplicativoDeConsole
{
    internal class Produto
    {
        public string nome;
        public double preço;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preço*quantidade;

        }

        public void AdicionarProdutos(int Quantidade)
        {
            quantidade += Quantidade;
        }

        public void RemoverProdutos(int Quantidade)
        {
            quantidade -= Quantidade;   
        }
    }
}