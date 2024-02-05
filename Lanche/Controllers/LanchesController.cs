using Lanche.Repositories.Interfaces;
using Lanche.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanche.Controllers
{
    public class LanchesController : Controller
    {
        private readonly ILancheRepositorio _lancheRepositorio;

        public LanchesController(ILancheRepositorio lancheRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepositorio.Lanches;
            //return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepositorio.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);

        }

        public IActionResult LanchePreferido()
        {
            var lanchesPreferidos = _lancheRepositorio.LanchesPreferido;
            return View(lanchesPreferidos);
        }

       
    }
}
