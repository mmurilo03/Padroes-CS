namespace ControleDeEstoque;
public class ProdutoConsoleOutputter
{
    Produto Produto { get; }
    public ProdutoConsoleOutputter(Produto produto)
    {
        Produto = produto;
    }
    public void Imprimir()
    {
        Console.WriteLine($"PRODUTO: Nome: {Produto.Nome} | Preço: {Produto.Preco} | Quantidade: {Produto.Quantidade}");
    }
}