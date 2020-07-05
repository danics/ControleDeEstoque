using System.Collections.Generic;
using System.Threading.Tasks;
using ControleDeEstoque.Domain.Produtos;

namespace ControleDeEstoque.Application.AppServices
{
    public class ProdutosAppServices : IProdutosAppServices
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutosAppServices(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<List<Produto>> GetAll()
        {
            return await _produtoRepositorio.GetAll();   
        }
    }
}