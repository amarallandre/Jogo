using Jogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jogo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        [HttpPost]
        public IActionResult CriarPersonagem(string nome, string classe)
        {
            using (var context = new DataBase())
            {
                var novoPersonagem = new Personagem
                {
                    Nome = nome,
                    Classe = classe
                };

                context.Personagens.Add(novoPersonagem);
                context.SaveChanges();
            }

            return RedirectToAction("PersonagemCriado", new { nome = nome, classe = classe });
        }

        private List<Inimigo> _inimigos = new List<Inimigo>();

        public IActionResult CriarInimigo()
        {
            return View(_inimigos);
        }

        [HttpPost]
        public IActionResult CriarInimigo(Inimigo inimigo)
        {
            _inimigos.Add(inimigo);
            return View(_inimigos);
        }
    }
}