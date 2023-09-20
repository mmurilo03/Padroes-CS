namespace ControleDeEstoque;

public class ItemCompraDisponibilidade
{
    ItemCompra ItemCompra { get; }
    public ItemCompraDisponibilidade(ItemCompra itemCompra)
    {
        ItemCompra = itemCompra;
    }
    public bool ChecarDisponibilidade()
    {
        bool disponivel = false;
        EstoqueBuscarProduto estoqueBuscarProduto = new(ItemCompra.Estoque);
        if (estoqueBuscarProduto.Buscar(ItemCompra.Produto) && ItemCompra.Produto.Quantidade > ItemCompra.Quantidade)
        {
            disponivel = true;
        }
        return disponivel;
    }
}
