using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeDex.Models;


namespace PokeDex.Controllers
{
    public class HomeController : Controller
    {

        private PokemonDbContext _context;
        public HomeController (PokemonDbContext c){
            _context=c;
        }
        public IActionResult Index()
        {
            var lista= _context.Pokemones.ToList();
            return View(lista);
        }

        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Pokemon p){
            if(ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }else{
                return View(p);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
