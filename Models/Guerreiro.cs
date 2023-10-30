namespace Jogo.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro()
        {
            Classe = "Guerreiro";
            DanoBase = 20;
            DefesaBase = 10;
            HPBase = 120;
            MPBase = 30;
        }
    }
}