namespace ControleDeEstoque;

public abstract class Cliente : ICliente
{
    public string Nome { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
    }

    public abstract double Pagar(Compra compra);
}