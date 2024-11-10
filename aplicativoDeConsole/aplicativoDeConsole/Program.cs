using aplicativoDeConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produtos = new Produto();

        Console.WriteLine("entre com os dados do produto");

        //entrada de dados 
        /*----------------nome do produto-------------------*/
        Console.WriteLine("nome do produto ");
        Console.ForegroundColor = ConsoleColor.Red;
        produtos.nome = Console.ReadLine();
        Console.ResetColor();

        /*----------------preço do produto-------------------*/
        Console.WriteLine("preço do produto ");
        Console.ForegroundColor = ConsoleColor.Red;
        produtos.preço = Convert.ToDouble(Console.ReadLine());
        Console.ResetColor();

        /*----------------quantidade do produto-------------------*/
        Console.WriteLine("quantidade do produto ");
        Console.ForegroundColor = ConsoleColor.Red;
        produtos.quantidade = Convert.ToInt32(Console.ReadLine());
        Console.ResetColor();

        //saida de dados 
        Console.WriteLine("\nDados do produto");
        Console.WriteLine($"\tnome do produto: {produtos.nome}");
        Console.WriteLine($"\tpreço do produto: R$ {produtos.preço:N}");
        Console.WriteLine($"\t quantidade do produto: {produtos.quantidade}");
        Console.WriteLine($"\t valor total em estoque do produto R${produtos.ValorTotalEmEstoque():N}");


        Console.Write("\n Digite a quantidade de produto a ser adicionada no estoque");
        Console.ForegroundColor= ConsoleColor.Red;
        int a = int .Parse( Console.ReadLine() );
        Console.ResetColor();

        produtos.AdicionarProdutos(a);

        //saida de dados
        Console.WriteLine("\nDados atualizado do produto");
        Console.WriteLine($"\tnome do produto: {produtos.nome}");
        Console.WriteLine($"\tpreço do produto: R$ {produtos.preço:N}");
        Console.WriteLine($"\t quantidade do produto: {produtos.quantidade}");
        Console.WriteLine($"\t valor total em estoque do produto R${produtos.ValorTotalEmEstoque():N}");




        Console.Write("\n Digite a quantidade de produto a ser removida no estoque");
        Console.ForegroundColor = ConsoleColor.Red;
        a = int.Parse(Console.ReadLine());
        Console.ResetColor();

        produtos.AdicionarProdutos(a);

        //saida de dados
        Console.WriteLine("\nDados atualizado do produto");
        Console.WriteLine($"\tnome do produto: {produtos.nome}");
        Console.WriteLine($"\tpreço do produto: R$ {produtos.preço:N}");
        Console.WriteLine($"\t quantidade do produto: {produtos.quantidade}");
        Console.WriteLine($"\t valor total em estoque do produto R${produtos.ValorTotalEmEstoque():N}");

    }
}