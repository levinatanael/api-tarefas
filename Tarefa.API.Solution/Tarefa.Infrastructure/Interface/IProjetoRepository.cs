using Tarefa.Domain.Entidades;

namespace Tarefa.Infrastructure.Interface
{
    public interface IProjetoRepository
    {
        Task<IEnumerable<Projeto>> ListarProjetosAsync();
        Task<Projeto> ObterProjetoPorIdAsync(int id);
        Task AdicionarProjetoAsync(Projeto projeto);
        Task RemoverProjetoAsync(int id);
    }
}
