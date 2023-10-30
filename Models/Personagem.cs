namespace Jogo.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "Seu nome";
        public string Classe { get; set; } = "null";

        public int DanoBase { get; protected set; }
        public int DefesaBase { get; protected set; }
        public int HPBase { get; protected set; }
        public int MPBase { get; protected set; }

        public int Dano { get; set; }
        public int Defesa { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }

        public Personagem()
        {
            Dano = DanoBase;
            Defesa = DefesaBase;
            HP = HPBase;
            MP = MPBase;
            Level = 1;
            Exp = 0;
        }
    }
}