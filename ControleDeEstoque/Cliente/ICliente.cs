namespace ControleDeEstoque;

public interface ICliente
{
    public string Nome { get; set; }
    public List<Compra> Compras { get; }
}