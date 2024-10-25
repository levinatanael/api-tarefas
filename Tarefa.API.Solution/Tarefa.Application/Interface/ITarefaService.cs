using Tarefa.Application.Dtos;

namespace Tarefa.Application.Interface
{
    public interface ITarefaService
    {
        Task<IEnumerable<TarefaDto>> ListarTarefasAsync();
        Task<TarefaDto> ObterTarefaPorIdAsync(int id);
        Task<TarefaDto> CriarTarefaAsync(TarefaDto tarefaDto);
        Task AtualizarTarefaAsync(TarefaDto tarefaDto);
        Task RemoverTarefaAsync(int id);
    }
}
