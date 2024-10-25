using Tarefa.Domain.Entidades;
using Xunit;

namespace Tarefa.Domain.Tests.Entidades
{
    public class ProjetoTests
    {
        [Fact]
        public void Projeto_DeveInicializarComValoresCorretos()
        {
            var projeto = new Projeto();

            Assert.Equal(0, projeto.Id);
            Assert.Null(projeto.Nome);
            Assert.Empty(projeto.Tarefas);
            Assert.Equal(default, projeto.DataCriacao);
        }

        [Fact]
        public void Projeto_DeveAdicionarTarefas()
        {
            var tarefa = new Domain.Entidades.Tarefa { Id = 1, Titulo = "Tarefa 1" };
            var projeto = new Projeto();

            projeto.Tarefas.Add(tarefa);

            Assert.Single(projeto.Tarefas);
            Assert.Equal(tarefa, projeto.Tarefas[0]);
        }

        [Fact]
        public void Projeto_DeveInicializarDataCriacaoCorretamente()
        {
            var projeto = new Projeto { DataCriacao = DateTime.Now };

            Assert.True(projeto.DataCriacao <= DateTime.Now);
        }
    }
}
