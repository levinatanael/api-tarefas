using Tarefa.Application.Interface;
using Tarefa.Domain.Entidades;
using Tarefa.Infrastructure.Interface;

namespace Tarefa.Application.Service
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository _projetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public async Task<List<Projeto>> ListarProjetosAsync()
        {
            return (await _projetoRepository.ListarProjetosAsync()).ToList();
        }

        public async Task<Projeto> ObterProjetoPorIdAsync(int id)
        {
            return await _projetoRepository.ObterProjetoPorIdAsync(id);
        }

        public async Task CriarProjetoAsync(Projeto projeto)
        {
            if (projeto.Tarefas.Count > 20)
                throw new InvalidOperationException("Um projeto não pode ter mais de 20 tarefas.");

            await _projetoRepository.AdicionarProjetoAsync(projeto);
        }
    }
}
