namespace ControleDeEstoque;

public class CompraCalcularTotal : ICompraCalcular
{
    public Compra Compra { get; }
    public CompraCalcularTotal(Compra compra)
    {
        Compra = compra;
    }
    public double Calcular()
    {
        double total = 0;
        foreach (ItemCompra itemCompra in Compra.ItensCompra)
        {
            ItemCompraGetPreco itemCompraGetPreco = new(itemCompra);
            total += itemCompraGetPreco.GetPreco();
        }
        return total;
    }
}