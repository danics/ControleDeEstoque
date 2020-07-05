using System.Collections.Generic;
using ControleDeEstoque.Domain.Produtos;

namespace ControleDeEstoque.Application.Dtos
{
    public class EstoqueDto
    {
        public int Id {get ; set;}
        public string Descricao {get; set;}
        public List<Produto> Produtos {get; set;} 
    }
}