using Lanche.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanche.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanches> Lanches { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    }
}
