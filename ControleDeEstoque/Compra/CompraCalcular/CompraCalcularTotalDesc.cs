namespace ControleDeEstoque;

public class CompraCalcularTotalDesc : ICompraCalcular
{

    public Compra Compra { get; }
    public double Desconto { get; set; }
    public CompraCalcularTotalDesc(Compra compra, double desconto)
    {
        Compra = compra;
        Desconto = desconto;
    }
    public double Calcular()
    {
        CompraCalcularTotal compraCalcularTotal = new(Compra);
        return Math.Round(compraCalcularTotal.Calcular() * (1 - (Desconto / 100)), 2);
    }
}