using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;
using MinhaApi.Models;

namespace MinhaApi.Services.Categoria;
public class CategoriaService : ICategoriaInterface
{
    private readonly AppDbContext context;
    public CategoriaService (AppDbContext context)
    {
        this.context = context;
    }
    public async Task<ResponseModel<CategoriaModel>> BuscarCategoriaporId(int idCategoria)
    {  
        ResponseModel<CategoriaModel> resposta = new();
        try
        {
            
        var categoria = await this.context.Categorias.FirstOrDefaultAsync(categoriaBanco => categoriaBanco.Id == idCategoria);

        if(categoria == null)
            {
                resposta.Mensagem = "Não foi encontrada nenhuma categoria com este Id";
                return resposta;
            }
        resposta.Dados = categoria;
        resposta.Mensagem = "Categoria Localizada com sucesso";
        return resposta;

        }catch(Exception e)
        {
            resposta.Mensagem = "Errooooo";
            resposta.Status = false;
            Console.WriteLine(e.Message);
            return resposta;
        }
    }

    public async Task<ResponseModel<CategoriaModel>> BuscarCategoriaporIdProduto(int Produto)
    {
        ResponseModel<CategoriaModel> resposta = new();
        try
        {
            var produto = await this.context.Produtos.Include(a => a.Categoria).FirstOrDefaultAsync(n => n.Id == Produto);
            if(produto == null)
            {
                resposta.Mensagem = "Nenhum registo encontrado";
                return resposta;
            }
            resposta.Dados = produto.Categoria;
            resposta.Mensagem = "Sucesso";
            return resposta;
        } 
        catch(Exception erro)
        {
        resposta.Mensagem = erro.Message;
        resposta.Status = false;
        return resposta;
        }
    }

    public async Task<ResponseModel<List<CategoriaModel>>> ListarCategorias()
    {
        ResponseModel<List<CategoriaModel>> resposta = new();
        try
        {
            var Categorias = await this.context.Categorias.ToListAsync();

            resposta.Dados = Categorias ;
            resposta.Mensagem = "Todos as Categorias foram coletadas com sucesso";
            
            return resposta;
            
        }catch(Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }
}