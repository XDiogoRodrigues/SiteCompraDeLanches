using Lanche.Repositories.Interfaces;
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
            var lanches = _lancheRepositorio.Lanches;
            return View(lanches);
        }

        public IActionResult LanchePreferido()
        {
            var lanchesPreferidos = _lancheRepositorio.LanchesPreferido;
            return View(lanchesPreferidos);
        }

       
    }
}
