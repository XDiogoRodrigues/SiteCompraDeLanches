using Lanche.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanche.Controllers
{
   
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaController(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public IActionResult List()
        {
            var categorias = _categoriaRepositorio.Categorias;
            return View(categorias);
        }

        public IActionResult Create()
        {

            return View();

        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
