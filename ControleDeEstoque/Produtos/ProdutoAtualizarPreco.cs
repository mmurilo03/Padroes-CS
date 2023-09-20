namespace ControleDeEstoque;

public class ProdutoAtualizarPreco : IObserver
{
    Produto Produto { get; }

    public ProdutoAtualizarPreco(Produto produto)
    {
        Produto = produto;
    }

    public void GerenteEnloqueceu(double promocao)
    {
        Produto.Preco = Math.Round(Produto.Preco * (1 - (promocao / 100)), 2);
    }
}