namespace ControleDeEstoque;

public class Estoque : IEstoque
{
    private double promocao = 0;
    public List<Produto> Produtos { get; }
    public List<IObserver> Observers { get; }

    public Estoque()
    {
        Produtos = new List<Produto>();
        Observers = new List<IObserver>();
    }

    public double Promocao 
    {
        get { return promocao; }
        set {
            promocao = value;
            foreach (IObserver observer in Observers)
            {
                observer.GerenteEnloqueceu(value);
            }
        } 
    }
}