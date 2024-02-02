using Lanche.Context;
using Lanche.Models;
using Lanche.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanche.Repositories
{
    public class LancheRepositorio: ILancheRepositorio
    {
        private readonly AppDbContext _context;

        public LancheRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanches> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanches> LanchesPreferido => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria);


        public Lanches GetLancheById(int LancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LanchesId == LancheId);
        }
    }
}
