using Microsoft.EntityFrameworkCore;
using Tarefa.Infrastructure.Context;
using Tarefa.Infrastructure.Interface;

namespace Tarefa.Infrastructure.Repository
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly ApplicationDbContext _context;

        public TarefaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Domain.Entidades.Tarefa>> GetAllByProjetoIdAsync(int projetoId)
        {
            return await _context.Tarefas.Where(t => t.ProjetoId == projetoId).ToListAsync();
        }

        public async Task<Domain.Entidades.Tarefa> GetByIdAsync(int id)
        {
            return await _context.Tarefas.FindAsync(id);
        }

        public async Task AddAsync(Domain.Entidades.Tarefa tarefa)
        {
            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Domain.Entidades.Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var tarefa = await GetByIdAsync(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Domain.Entidades.Tarefa>> GetAll()
        {
            return await _context.Tarefas.ToListAsync();
        }
    }
}
