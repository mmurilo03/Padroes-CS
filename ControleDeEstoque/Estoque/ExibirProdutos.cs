namespace ControleDeEstoque;

public class ExibirProdutos
{

    Estoque Estoque { get; }
    public ExibirProdutos(Estoque estoque)
    {
        Estoque = estoque;
    }
    public void Exibir()
    {
        for (int i = 0; i < Estoque.Produtos.Count; i++)
        {
            EstoqueGetProduto estoqueGetProduto = new(Estoque);
            Produto produto = estoqueGetProduto.GetProduto(i);
            ProdutoConsoleOutputter produtoConsoleOutputter = new(produto);
            produtoConsoleOutputter.Imprimir();
        }
    }
}