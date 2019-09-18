using LigaPokemon.Models;
using Microsoft.AspNetCore.Mvc;

namespace LigaPokemon.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(){
            return View();
        }

        public IActionResult Formulario(){
            return  View();
        }
        [HttpPost]
        public IActionResult Formulario(Entrenador entrenador){
            if(ModelState.IsValid){
                //Guardar en BD
                return RedirectToAction("Confirmacion");
            }else{
                return View(entrenador);
            }
            
        }

        public IActionResult Confirmacion(){
            return View();
        }
    }
}