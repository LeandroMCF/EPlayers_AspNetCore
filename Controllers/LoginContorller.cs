using EPlayers_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_AspNetCore.Controllers
{
    [Route("Login")]
    public class LoginContorller : Controller
    {
        Jogador jogadorModel = new Jogador();
    }
}