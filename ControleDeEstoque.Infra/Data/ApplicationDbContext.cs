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

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estoque>().HasData(new Estoque { Id = 1, Descricao = "Estoque Padrao" });
            base.OnModelCreating(modelBuilder);
        }
    }

}