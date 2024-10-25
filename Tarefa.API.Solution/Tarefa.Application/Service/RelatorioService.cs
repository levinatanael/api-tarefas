using Microsoft.EntityFrameworkCore;
using Tarefa.Application.Interface;
using Tarefa.Infrastructure.Context;

namespace Tarefa.Application.Service
{
    public class RelatorioService : IRelatorioService
    {
        private readonly ApplicationDbContext _context;

        public RelatorioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> ObterMediaTarefasConcluidasAsync(int ultimosDias)
        {
            var dataInicio = DateTime.Now.AddDays(-ultimosDias);

            var tarefasConcluidas = await _context.Tarefas
                .Where(t => t.Status == "Concluída" && t.DataVencimento >= dataInicio)
                .CountAsync();

            var usuarios = await _context.Tarefas
                .Where(t => t.Status == "Concluída" && t.DataVencimento >= dataInicio)
                .Select(t => t.UsuarioId)
                .Distinct()
                .CountAsync();

            return usuarios == 0 ? 0 : tarefasConcluidas / usuarios;
        }
    }
}
