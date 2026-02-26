using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MinhaApi.Models;
using MinhaApi.Services.Categoria;

namespace MinhaApi.Controllers
{
        [Route("api/Controller")]
        [ApiController]
    public class CategoriaController : ControllerBase
    {
    private readonly ICategoriaInterface categoriaInterface;
    public CategoriaController(ICategoriaInterface categoriaInterface)
    {
        this.categoriaInterface = categoriaInterface;
    }
    [HttpGet("listarCategorias")]
    public async Task<ActionResult<ResponseModel<List<CategoriaModel>>>> ListarCategorias()
        {
            var categorias = await this.categoriaInterface.ListarCategorias();
            return Ok(categorias);
        }
    [HttpGet("BuscarCategoriaporId/{IdCategoria}")]
    public async Task<ActionResult<ResponseModel<CategoriaModel>>> BuscarCategoriaporId(int idCategoria)
        {
            var categorias = await this.categoriaInterface.BuscarCategoriaporId(idCategoria);
            return Ok(categorias);
        }    
    [HttpDelete("BuscarCategoriaporIdProduto/{idProduto}")]
    public async Task<ActionResult<ResponseModel<CategoriaModel>>> BuscarCategoriaporIdProduto(int IdProduto)
        {
            var categorias = await this.categoriaInterface.BuscarCategoriaporIdProduto(IdProduto);
            return Ok(categorias);
        }
      };
}