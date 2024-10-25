namespace Tarefa.Application.Interface
{
    public interface IRelatorioService
    {
        Task<int> ObterMediaTarefasConcluidasAsync(int ultimosDias);
    }
}
