namespace ControleDeEstoque;

public class EstoqueBuscarProduto
{
    Estoque Estoque { get; }
    public EstoqueBuscarProduto(Estoque estoque)
    {
        Estoque = estoque;
    }
    public bool Buscar(Produto produto)
    {
        foreach (Produto p in Estoque.Produtos)
        {
            if (p.Nome.ToLower().Equals(produto.Nome.ToLower()))
            {
                return true;
            }
        }
        return false;
    }
}