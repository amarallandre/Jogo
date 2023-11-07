namespace Jogo.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro()
        {
            Classe = "Guerreiro";
            DanoBase = 20;
            DefesaBase = 10;
            HP = 120;
            MP = 30;
        }
    }
}