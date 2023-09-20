namespace ConsoleApp;
using ControleDeEstoque;

public class Program
{
    static void Main(string[] args)
    {
        Estoque estoque = new();

        Produto produto = new("Carro Hot Wheels", 14.99, 50);

        Produto produto2 = new("Max steel", 108.99, 12);

        Produto produto3 = new("Barbie Sereia", 249.99, 3);

        Produto produto4 = new("PlayStation 2", 479.98, 20);

        EstoqueAddProduto estoqueAddProduto = new(estoque);

        estoqueAddProduto.AddProduto(produto);
        estoqueAddProduto.AddProduto(produto2);
        estoqueAddProduto.AddProduto(produto3);
        estoqueAddProduto.AddProduto(produto4);

        ProdutoAtualizarPreco produtoAtualizarPreco = new(produto);
        ProdutoAtualizarPreco produtoAtualizarPreco2 = new(produto2);
        ProdutoAtualizarPreco produtoAtualizarPreco3 = new(produto3);
        ProdutoAtualizarPreco produtoAtualizarPreco4 = new(produto4);

        ExibirProdutos exibirProdutos = new(estoque);

        EstoqueAddObserver estoqueAddObserver = new(estoque);

        estoqueAddObserver.AddObserver(produtoAtualizarPreco);
        estoqueAddObserver.AddObserver(produtoAtualizarPreco2);
        estoqueAddObserver.AddObserver(produtoAtualizarPreco3);
        estoqueAddObserver.AddObserver(produtoAtualizarPreco4);

        exibirProdutos.Exibir();

        Compra compra = new();

        CompraAddItem compraAddItem = new(compra);

        compraAddItem.AddItem(produto, estoque, 3);

        ItemCompra itemCompra = new(produto, estoque, 6);

        CompraRemItem compraRemItem = new(compra);
        compraRemItem.RemItem(produto, estoque, 3);
        compraRemItem.RemItem(itemCompra);

        CompraCalcularTotal compraCalcularTotal = new(compra);
        CompraCalcularTotalDesc compraCalcularTotalDesc = new(compra, 10);
        CompraCalcularComTaxa compraCalcularComTaxa = new(compra, 10);
        
        estoque.Promocao = 10;

        exibirProdutos.Exibir();
    }
}