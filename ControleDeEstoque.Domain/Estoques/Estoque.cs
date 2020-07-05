using System.Collections.Generic;
using ControleDeEstoque.Domain.Produtos;

namespace ControleDeEstoque.Domain.Estoques
{
    public class Estoque
    {
        public int Id {get ; set;}
        public string Descricao {get; set;}
        public List<Produto> Produtos {get; set;}        
    }
}