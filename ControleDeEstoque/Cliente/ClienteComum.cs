namespace ControleDeEstoque;

public class ClienteComum : Cliente
{

    public ClienteComum(string nome) : base(nome)
    {
    }

    public override double Pagar(Compra compra)
    {
        CompraCalcularTotal compraCalcularTotal = new(compra);
        return compraCalcularTotal.Calcular();
    }
}