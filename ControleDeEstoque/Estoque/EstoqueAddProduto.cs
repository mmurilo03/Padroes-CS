namespace ControleDeEstoque;

public class EstoqueAddProduto
{
    Estoque Estoque { get; }
    public EstoqueAddProduto(Estoque estoque)
    {
        Estoque = estoque;
    }
    public void AddProduto(Produto prod)
    {
        Estoque.Produtos.Add(prod);
    }
}