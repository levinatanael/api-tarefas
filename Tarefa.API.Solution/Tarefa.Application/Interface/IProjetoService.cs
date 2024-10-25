using Tarefa.Domain.Entidades;

namespace Tarefa.Application.Interface
{
    public interface IProjetoService
    {
        Task<List<Projeto>> ListarProjetosAsync();
        Task<Projeto> ObterProjetoPorIdAsync(int id);
        Task CriarProjetoAsync(Projeto projeto);
    }
}
