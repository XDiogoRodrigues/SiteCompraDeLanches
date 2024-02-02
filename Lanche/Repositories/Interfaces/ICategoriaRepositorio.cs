using Lanche.Models;

namespace Lanche.Repositories.Interfaces
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
