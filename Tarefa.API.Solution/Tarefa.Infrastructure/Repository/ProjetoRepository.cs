using Microsoft.EntityFrameworkCore;
using Tarefa.Domain.Entidades;
using Tarefa.Infrastructure.Context;
using Tarefa.Infrastructure.Interface;

namespace Tarefa.Infrastructure.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjetoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Projeto>> ListarProjetosAsync()
        {
            return await _context.Projetos.Include(p => p.Tarefas).ToListAsync();
        }

        public async Task<Projeto> ObterProjetoPorIdAsync(int id)
        {
            return await _context.Projetos.Include(p => p.Tarefas)
                                          .ThenInclude(t => t.Comentarios)
                                          .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AdicionarProjetoAsync(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverProjetoAsync(int id)
        {
            var projeto = await ObterProjetoPorIdAsync(id);
            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();
        }
    }
}
