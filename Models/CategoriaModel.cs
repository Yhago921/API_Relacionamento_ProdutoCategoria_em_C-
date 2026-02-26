using System.Text.Json.Serialization;

namespace MinhaApi.Models;

public class CategoriaModel
{
    public int Id { get; set; }
    
    public string ? Nome { get; set; }
    
    [JsonIgnore]
    public ICollection<ProdutoModel>? Produtos {get; set;}
    
}