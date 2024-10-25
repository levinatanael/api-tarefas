using System.Collections.Generic;

namespace Tarefa.Application.Dtos
{
    public class ProjetoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<TarefaDto> Tarefas { get; set; }
    }
}