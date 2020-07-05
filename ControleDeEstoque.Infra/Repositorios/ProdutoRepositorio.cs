using System.Collections.Generic;
using System.Threading.Tasks;
using ControleDeEstoque.Domain.Produtos;
using ControleDeEstoque.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Infra.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> GetAll()
        {
            return await _context.Produtos.ToListAsync();            
        }
    }
}