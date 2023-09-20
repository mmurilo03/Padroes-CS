namespace ControleDeEstoque;

public class EstoqueAddObserver
{
    Estoque Estoque { get; }
    public EstoqueAddObserver(Estoque estoque)
    {
        Estoque = estoque;
    }
    public void AddObserver(IObserver observer)
    {
        Estoque.Observers.Add(observer);
    }
}