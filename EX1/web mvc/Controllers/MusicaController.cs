using Microsoft.AspNetCore.Mvc;
using web_mvc.Models;
using web_mvc.Repositorios;

namespace web_mvc.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Welcome(string nome){
            ViewData["Mensagem"] = "Olá "+ nome + ", estas são as suas músicas: ";
                        
            var musica = MusicaRepositorio.musicas[0];

            return View(MusicaRepositorio.musicas);
        }
    }
}