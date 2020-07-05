using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Produtos
{
    public interface IProdutoRepositorio
    {
        Task<List<Produto>> GetAll();
    }
}