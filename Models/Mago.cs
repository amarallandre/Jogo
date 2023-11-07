namespace Jogo.Models
{
    public class Mago : Personagem
    {
        public Mago()
        {
            Classe = "Mago";
            DanoBase = 15;
            DefesaBase = 5;
            HP = 80;
            MP = 100;
        }
    }
}