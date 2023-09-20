namespace ControleDeEstoque;

class CompraRemItem
{
    public Compra Compra { get; }
    public CompraRemItem(Compra compra)
    {
        Compra = compra;
    }
    public void RemItem(Produto produto, Estoque estoque, int quantidade)
    {
        foreach (ItemCompra itemCompra in Compra.ItensCompra.ToList())
        {
            if (itemCompra.Produto.Equals(produto) && itemCompra.Estoque.Equals(estoque) && itemCompra.Quantidade.Equals(quantidade))
            {
                Compra.ItensCompra.Remove(itemCompra);
                produto.Quantidade += quantidade;
                Console.WriteLine("Item removido, quantidade retornado ao estoque");
            }
            else
            {
                Console.WriteLine("Item não está na compra");
            }
        }
    }

    public void RemItem(ItemCompra itemCompra)
    {
        ItemCompra? check = Compra.ItensCompra.Find(i => i.Equals(itemCompra));
        { }
        if (check != null)
        {
            Compra.ItensCompra.Remove(itemCompra);
            itemCompra.Produto.Quantidade -= itemCompra.Quantidade;
            Console.WriteLine("Item removido, quantidade retornado ao estoque");
        }
        else
        {
            Console.WriteLine("Item não está na compra");
        }
    }
}