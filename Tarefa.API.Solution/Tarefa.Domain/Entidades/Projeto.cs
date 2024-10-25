namespace Tarefa.Domain.Entidades
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Tarefa> Tarefas { get; set; } = [];
        public DateTime DataCriacao { get; set; }
    }
}
