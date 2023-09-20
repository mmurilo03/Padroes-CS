namespace ControleDeEstoque;

public interface IItemCompra
{
    public Produto Produto { get; }
    public Estoque Estoque { get; }
    public int Quantidade { get; }
}