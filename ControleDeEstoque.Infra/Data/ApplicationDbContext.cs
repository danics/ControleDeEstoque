using ControleDeEstoque.Domain.Estoques;
using ControleDeEstoque.Domain.Produtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Infra.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base (options)
        {
        }

        public DbSet<Produto> Produtos {get; set;}
        public DbSet<Estoque> Estoques {get; set;}
    }

}