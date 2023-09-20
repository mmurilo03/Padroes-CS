namespace ControleDeEstoque;

public class ItemCompraGetPreco
{
    ItemCompra ItemCompra { get; }
    public ItemCompraGetPreco(ItemCompra itemCompra)
    {
        ItemCompra = itemCompra;
    }
    public double GetPreco()
    {
        return ItemCompra.Produto.Preco * ItemCompra.Quantidade;
    }
}