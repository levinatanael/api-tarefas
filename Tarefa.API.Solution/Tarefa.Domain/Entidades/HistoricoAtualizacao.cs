namespace Tarefa.Domain.Entidades
{
    public class HistoricoAtualizacao
    {
        public int Id { get; set; }
        public string Mudanca { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}
