namespace Jogo.Models
{
    public class Mago : Personagem
    {
        public Mago()
        {
            Classe = "Mago";
            DanoBase = 15;
            DefesaBase = 5;
            HPBase = 80;
            MPBase = 100;
        }
    }
}