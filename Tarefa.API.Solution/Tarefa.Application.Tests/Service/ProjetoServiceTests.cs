using Moq;
using Tarefa.Application.Service;
using Tarefa.Domain.Entidades;
using Tarefa.Infrastructure.Interface;
using Xunit;

namespace Tarefa.Application.Tests.Service
{
    public class ProjetoServiceTests
    {
        private readonly Mock<IProjetoRepository> _projetoRepositoryMock;
        private readonly ProjetoService _projetoService;

        public ProjetoServiceTests()
        {
            _projetoRepositoryMock = new Mock<IProjetoRepository>();
            _projetoService = new ProjetoService(_projetoRepositoryMock.Object);
        }

        [Fact]
        public async Task CriarProjeto_NaoDevePermitirMaisDe20Tarefas()
        {
            var projeto = new Projeto { Tarefas = new List<Domain.Entidades.Tarefa>(Enumerable.Repeat(new Domain.Entidades.Tarefa(), 21)) };

            await Assert.ThrowsAsync<InvalidOperationException>(() => _projetoService.CriarProjetoAsync(projeto));
        }
    }
}
