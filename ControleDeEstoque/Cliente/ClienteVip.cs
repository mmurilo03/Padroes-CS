namespace ControleDeEstoque;

public class ClienteVip : Cliente
{
    private readonly double desconto = 0.95;

    public ClienteVip(string nome) : base(nome)
    {
    }

    public override double Pagar(Compra compra)
    {
        CompraCalcularTotal compraCalcularTotal = new(compra);
        return compraCalcularTotal.Calcular() * desconto; // 5% de desconto 🚀👌
    }
}