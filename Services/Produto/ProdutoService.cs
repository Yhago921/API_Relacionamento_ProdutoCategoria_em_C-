using MinhaApi.Models;

namespace MinhaApi.Services.Produto;

public class ProdutoService : IProdutoInterface
{
    public Task<ResponseModel<ProdutoModel>> BuscarProdutoPorId(int IdProduto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<List<ProdutoModel>>> ListarProdutos()
    {
        throw new NotImplementedException();
    }
}