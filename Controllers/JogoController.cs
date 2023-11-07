using Microsoft.AspNetCore.Mvc;
using Jogo.Models;
using Jogo.Views.Jogo;
using Jogo.Migrations;

namespace Jogo.Controllers
{
    public class JogoController : Controller
    {
        private readonly DataBase _dbContext;

        public JogoController(DataBase dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Jogo(int id)
        {
            var personagem = _dbContext.Personagens.Find(id);

            if (personagem == null)
            {
                // Lógica de tratamento de erro se o personagem não for encontrado
                return RedirectToAction("Index", "Personagem");
            }

            var random = new Random();
            var inimigoIds = _dbContext.Inimigos.Select(i => i.Id).ToList();

            if (inimigoIds.Count == 0)
            {
                // Lógica se não houver inimigos disponíveis
                return RedirectToAction("Index", "Personagem");
            }

            var randomInimigoId = inimigoIds[random.Next(inimigoIds.Count)];
            var inimigo = _dbContext.Inimigos.Find(randomInimigoId);

            var viewModel = new DetalhesJogoViewModel
            {
                Personagem = personagem,
                Inimigo = inimigo
            };

            return View("~/Views/Jogo/Jogo.cshtml", viewModel);
        }

    }
}
