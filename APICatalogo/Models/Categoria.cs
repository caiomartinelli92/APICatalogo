using System.Collections.ObjectModel;

namespace APICatalogo.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }
    //Criando a coleção de produtos, irá fazer o vínculo de produtos e categorias
    public ICollection<Produto>? Produtos { get; set; }

    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
}
