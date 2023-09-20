namespace ControleDeEstoque;

public class Compra : ICompra
{
    public List<ItemCompra> ItensCompra { get; }

    public Compra()
    {
        ItensCompra = new List<ItemCompra>();
    }
}