namespace ControleDeEstoque;

public class EstoqueGetProduto
{

    Estoque Estoque { get; }
    public EstoqueGetProduto(Estoque estoque)
    {
        Estoque = estoque;
    }
    public Produto GetProduto(int posicao)
    {
        return Estoque.Produtos[posicao];
    }
}