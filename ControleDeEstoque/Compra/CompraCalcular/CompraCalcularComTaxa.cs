namespace ControleDeEstoque;

public class CompraCalcularComTaxa : ICompraCalcular
{
    public Compra Compra { get; }
    public double Taxa { get; set; }
    public CompraCalcularComTaxa(Compra compra, double taxa)
    {
        Compra = compra;
        Taxa = taxa;
    }
    public double Calcular()
    {
        //a taxa será atribuida ao cliente
        CompraCalcularTotal compraCalcularTotal = new(Compra);
        return Math.Round(compraCalcularTotal.Calcular() * (1 + (Taxa / 100)), 2);
    }
}