using Jogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Jogo.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly DataBase _dbContext;

        public PersonagemController(DataBase dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CriarPersonagem(string nome, string classe)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(classe))
            {
                // Lógica de tratamento de erro, se necessário
                return RedirectToAction("Index", "Home");
            }

            Personagem novoPersonagem;

            switch (classe.ToLower())
            {
                case "mago":
                    novoPersonagem = new Mago();
                    break;

                case "arqueiro":
                    novoPersonagem = new Arqueiro();
                    break;

                case "guerreiro":
                    novoPersonagem = new Guerreiro();
                    break;

                default:
                    // Lógica de tratamento de erro, se necessário
                    return RedirectToAction("Index", "Home");
            }

            novoPersonagem.Nome = nome;

            _dbContext.Personagens.Add(novoPersonagem);
            _dbContext.SaveChanges();

            return RedirectToAction("DetalhesPersonagem", new { id = novoPersonagem.Id });
        }

        [HttpPost]
        public IActionResult SelecionarPersonagem(int personagemId)
        {
            var personagemSelecionado = _dbContext.Personagens.FirstOrDefault(p => p.Id == personagemId);

            if (personagemSelecionado != null)
            {
                // Serializar o objeto para JSON antes de armazená-lo na sessão
                var personagemJson = JsonSerializer.Serialize(personagemSelecionado);

                // Corrigir a chamada para a sessão
                HttpContext.Session.SetString("PersonagemSelecionado", personagemJson);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            var personagens = _dbContext.Personagens.ToList();

            return View(personagens);
        }
    }
}