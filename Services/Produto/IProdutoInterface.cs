using MinhaApi.Models;

namespace MinhaApi.Services.Produto;

public interface IProdutoInterface
{
    Task<ResponseModel<List<ProdutoModel>>> ListarProdutos();

    Task<ResponseModel<ProdutoModel>> BuscarProdutoPorId(int IdProduto);
}