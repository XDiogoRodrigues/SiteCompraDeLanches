using Lanche.Models;

namespace Lanche.Repositories.Interfaces
{
    public interface ILancheRepositorio
    {
        IEnumerable<Lanches> Lanches { get; }
        IEnumerable<Lanches> LanchesPreferido { get; }
        Lanches GetLancheById(int lancheId); 
        
    }
}
