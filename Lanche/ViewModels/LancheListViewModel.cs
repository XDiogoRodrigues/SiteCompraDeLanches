using Lanche.Models;

namespace Lanche.ViewModels
{
	public class LancheListViewModel
	{
        public IEnumerable<Lanches> Lanches { get; set; }
		public string CategoriaAtual { get; set; }
    }
}
