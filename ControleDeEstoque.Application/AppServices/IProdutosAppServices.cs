using System.Collections.Generic;
using System.Threading.Tasks;
using ControleDeEstoque.Domain.Produtos;

namespace ControleDeEstoque.Application.AppServices
{
    public interface IProdutosAppServices
    {
        Task<List<Produto>> GetAll();
    }
}