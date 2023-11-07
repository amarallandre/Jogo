namespace Jogo.Models
{
    public class Arqueiro : Personagem
    {
        public Arqueiro()
        {
            Classe = "Arqueiro";
            DanoBase = 12;
            DefesaBase = 8;
            HP = 100;
            MP = 50;
        }
    }
}