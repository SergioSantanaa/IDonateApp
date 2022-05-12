namespace IDonateApp.Models
{
    public class Avaliacao
    {
         public int AvaliacaoId { get; set; }

         public int QuantidadeEstrelas { get; set; }

         public int OngId { get; set; }

         public int UsuarioId { get; set; }

         public string Comentario { get; set; }

         public string Resposta { get; set; }
    }
}