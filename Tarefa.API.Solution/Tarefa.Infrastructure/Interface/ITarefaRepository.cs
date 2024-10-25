namespace Tarefa.Infrastructure.Interface
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Domain.Entidades.Tarefa>> GetAllByProjetoIdAsync(int projetoId);
        Task<Domain.Entidades.Tarefa> GetByIdAsync(int id);
        Task AddAsync(Domain.Entidades.Tarefa tarefa);
        Task UpdateAsync(Domain.Entidades.Tarefa tarefa);
        Task DeleteAsync(int id);
        Task<IEnumerable<Domain.Entidades.Tarefa>> GetAll();
    }
}
