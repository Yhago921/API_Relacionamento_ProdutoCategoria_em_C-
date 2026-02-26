namespace MinhaApi.Models;
public class ProdutoModel
{
    public int Id { get; set; }

    public string? Nome { get; set; } 
    
    public int CategoriaId {get; set; }
    public CategoriaModel ?  Categoria { get; set; }

}