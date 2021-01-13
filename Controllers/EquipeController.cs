using System;
using EPlayers_AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_AspNetCore.Controllers
{
    [Route("Equipe")]
    public class EquipeController : Controller
    {
        Equipe equipe = new Equipe();

        [Route("Listar")]

        public IActionResult Index()
        {
            ViewBag.Equipes = equipe.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            equipe.Create(novaEquipe);
            ViewBag.Equipes = equipe.ReadAll();

            return LocalRedirect("~/Equipe/Listar");
        }
    }
}