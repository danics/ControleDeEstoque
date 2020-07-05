using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeEstoque.Application.Dtos
{
    public class ProdutoDto
    {
        public int Id {get; set;}
        public string Descricao {get; set;}
        
        [ForeignKey("EstoqueId")]
        public int EstoqueId {get; set;}
    }
}