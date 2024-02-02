using Lanche.Context;
using Lanche.Models;
using Lanche.Repositories.Interfaces;

namespace Lanche.Repositories
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly AppDbContext _context;

        public CategoriaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias; // Expression bodied member
    }
}
