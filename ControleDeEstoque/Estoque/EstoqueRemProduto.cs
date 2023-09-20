namespace ControleDeEstoque;

public class EstoqueRemProduto
{
    Estoque Estoque { get; }
    public EstoqueRemProduto(Estoque estoque)
    {
        Estoque = estoque;
    }
    public void RemProduto(Produto prod)
    {
        Estoque.Produtos.Remove(prod);
    }
}