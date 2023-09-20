namespace ControleDeEstoque;

public abstract class Cliente : ICliente
{
    public string Nome { get; set; }
    public List<Compra> Compras { get; }

    public Cliente(string nome)
    {
        Nome = nome;
        Compras = new List<Compra>();
    }

    public abstract double Pagar(Compra compra);
}