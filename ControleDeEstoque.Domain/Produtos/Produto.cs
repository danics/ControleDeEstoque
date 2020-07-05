using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeEstoque.Domain.Produtos
{
    public class Produto
    {
        public int Id {get; set;}
        public string Descricao {get; set;}
        
        [ForeignKey("EstoqueId")]
        public int EstoqueId {get; set;}
                
    }
    
}