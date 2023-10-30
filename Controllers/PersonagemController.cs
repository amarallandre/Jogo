using Jogo.Models; // Adicione esta linha para resolver o erro relacionado a DataBase
using Microsoft.AspNetCore.Mvc; // Adicione esta linha para resolver os erros relacionados a Controller e IActionResult
using Microsoft.EntityFrameworkCore;
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

            // Alteração aqui: redirecione para a ação Index da mesma controller
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SelecionarPersonagem(int personagemId)
        {
            var personagemSelecionado = _dbContext.Personagens.FirstOrDefault(p => p.Id == personagemId);

            if (personagemSelecionado == null)
            {
                // Lógica de tratamento de erro se o personagem não for encontrado
                return RedirectToAction("Index");
            }

            // Alteração aqui: redirecione para a página "Jogo/Jogo" passando o id como parâmetro
            return RedirectToAction("Jogo", new { id = personagemId });
        }

        public IActionResult Index()
        {
            var personagens = _dbContext.Personagens.ToList();
            return View("~/Views/Home/Index.cshtml", personagens);
        }
    

        [HttpPost]
        public IActionResult ExcluirPersonagem(int personagemId)
        {
            var personagemParaExcluir = _dbContext.Personagens.FirstOrDefault(p => p.Id == personagemId);

            if (personagemParaExcluir != null)
            {
                _dbContext.Personagens.Remove(personagemParaExcluir);
                _dbContext.SaveChanges();
            }

            // Redirecionar de volta para a página de personagens após a exclusão
            return RedirectToAction("Index", "Personagem");
        }

        public IActionResult Jogo(int id)
        {
            // Lógica para obter as informações detalhadas do personagem usando o ID
            var personagem = _dbContext.Personagens.Find(id);

            if (personagem == null)
            {
                // Lógica de tratamento de erro se o personagem não for encontrado
                return RedirectToAction("Index");
            }

            // Passe as informações do personagem para a visualização
            return View("~/Views/Jogo/Jogo.cshtml", personagem);
        }
    }
}