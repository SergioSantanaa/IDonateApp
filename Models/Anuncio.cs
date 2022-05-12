namespace IDonateApp.Models
{
    public class Anuncio
    {
    
        public int AnuncioId { get; set; }

        public int OngId { get; set; }

        public int DataCriacao { get; set; }

        public int DataExpiracao { get; set; }

        public int DoacaoId { get; set; }
    }
}