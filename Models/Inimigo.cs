namespace Jogo.Models
{
    public class Inimigo
    {
        public int Id { get; set; }  // Adicione uma propriedade Id como chave primária
        public string Nome { get; set; }
        public int HP { get; set; }
        public int Dano { get; set; }

        public Inimigo()
        {
            Nome = ""; // ou outro valor padrão
        }
    }
}
