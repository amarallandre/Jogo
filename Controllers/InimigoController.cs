using Microsoft.AspNetCore.Mvc;
using Jogo.Models;

public class InimigoController : Controller
{
    private readonly DataBase _context;

    public InimigoController(DataBase context)
    {
        _context = context;
    }

    public IActionResult CriarInimigo()
    {
        var inimigos = _context.Inimigos.ToList();
        return View(inimigos);
    }

    [HttpPost]
    public IActionResult CriarInimigo(Inimigo inimigo)
    {
        _context.Inimigos.Add(inimigo);
        _context.SaveChanges();
        var inimigos = _context.Inimigos.ToList();
        return View(inimigos);
    }

    [HttpPost]
    public IActionResult ExcluirInimigo(int inimigoId)
    {
        var inimigoParaExcluir = _context.Inimigos.Find(inimigoId);

        if (inimigoParaExcluir != null)
        {
            _context.Inimigos.Remove(inimigoParaExcluir);
            _context.SaveChanges();
        }

        return RedirectToAction(nameof(CriarInimigo));
    }



}