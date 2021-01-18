using EPlayers_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_AspNetCore.Controllers
{
    [Route("Login")]
    public class LoginContorller : Controller
    {
        [TempData]
        public string Mensagem { get; set; }
        Jogador jogadorModel = new Jogador();
        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            return LocalRedirect("~/");
        }
    }
}