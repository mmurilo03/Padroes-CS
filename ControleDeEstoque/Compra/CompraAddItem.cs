namespace ControleDeEstoque;

class CompraAddItem
{
    public Compra Compra { get; }
    public CompraAddItem(Compra compra)
    {
        Compra = compra;
    }
    public void AddItem(Produto produto, Estoque estoque, int quantidade)
    {
        ItemCompra itemCompra = new(produto, estoque, quantidade);
        ItemCompraDisponibilidade itemCompraDisponibilidade = new(itemCompra);
        if (itemCompraDisponibilidade.ChecarDisponibilidade())
        {
            Compra.ItensCompra.Add(itemCompra);
            produto.Quantidade -= quantidade;
            Console.WriteLine("Item adicionado, quantidade removida ao estoque");
        }
        else
        {
            Console.WriteLine("Quantidade indisponível!");
        }
    }

    public void AddItem(ItemCompra itemCompra)
    {
        ItemCompraDisponibilidade itemCompraDisponibilidade = new(itemCompra);
        if (itemCompraDisponibilidade.ChecarDisponibilidade())
        {
            Compra.ItensCompra.Add(itemCompra);
            itemCompra.Produto.Quantidade -= itemCompra.Quantidade;
            Console.WriteLine("Item adicionado, quantidade removida ao estoque");
        }
        else
        {
            Console.WriteLine("Quantidade indisponível!");
        }
    }
}