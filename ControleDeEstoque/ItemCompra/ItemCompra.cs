namespace ControleDeEstoque;

public class ItemCompra : IItemCompra
{
    public Produto Produto { get; }
    public Estoque Estoque { get; }
    public int Quantidade { get; }

    public ItemCompra(Produto produto, Estoque estoque, int quantidade)
    {
        Produto = produto;
        Estoque = estoque;
        Quantidade = quantidade;
    }
}