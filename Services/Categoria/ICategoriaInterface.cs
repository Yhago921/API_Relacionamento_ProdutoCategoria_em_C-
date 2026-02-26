using MinhaApi.Models;

namespace MinhaApi.Services.Categoria;
public interface ICategoriaInterface
{
    Task<ResponseModel<List<CategoriaModel>>> ListarCategorias();

    Task<ResponseModel<CategoriaModel>> BuscarCategoriaporId(int idCategoria);

    Task<ResponseModel<CategoriaModel>> BuscarCategoriaporIdProduto (int Produto);
    
}