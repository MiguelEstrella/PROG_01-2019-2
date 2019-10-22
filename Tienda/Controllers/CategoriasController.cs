using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tienda.Models;

namespace Tienda.Controllers
{
    public class CategoriasController : Controller
    {
        private TiendaContext _context;

        public CategoriasController(TiendaContext x){
            _context= x;
        }

        public IActionResult index(){
            var lista = _context.Categorias.Include(x=> x.Productos).ToList();

            return View(lista);
        }

        public IActionResult Registrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Categoria x){
            if(ModelState.IsValid){
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}