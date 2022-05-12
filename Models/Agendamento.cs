namespace IDonateApp.Models
{
    public class Agendamento
    {
        public int AgendamentoId { get; set; }

        public int OngId { get; set; }

        public int Data { get; set; }
        
        public int UsuarioId { get; set; }
    }
}