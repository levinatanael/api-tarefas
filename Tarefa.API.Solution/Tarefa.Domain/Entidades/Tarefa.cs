namespace Tarefa.Domain.Entidades
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public int UsuarioId { get; set; }
        public int ProjetoId { get; set; }
        public List<Comentario> Comentarios { get; set; } = [];
        public List<HistoricoAtualizacao> Historicos { get; set; } = [];
    }
}
