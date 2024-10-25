using Tarefa.Domain.Entidades;
using Xunit;

namespace Tarefa.Domain.Tests.Entidades
{
    public class TarefaTests
    {
        [Fact]
        public void Tarefa_DeveInicializarComValoresCorretos()
        {
            var tarefa = new Domain.Entidades.Tarefa();

            Assert.Equal(0, tarefa.Id);
            Assert.Null(tarefa.Titulo);
            Assert.Null(tarefa.Descricao);
            Assert.Equal(default, tarefa.DataVencimento);
            Assert.Null(tarefa.Status);
            Assert.Null(tarefa.Prioridade);
            Assert.Empty(tarefa.Comentarios);
            Assert.Empty(tarefa.Historicos);
        }

        [Fact]
        public void Tarefa_DeveAdicionarComentario()
        {
            var comentario = new Comentario { Id = 1, Conteudo = "Comentário 1" };
            var tarefa = new Domain.Entidades.Tarefa();

            tarefa.Comentarios.Add(comentario);

            Assert.Single(tarefa.Comentarios);
            Assert.Equal(comentario, tarefa.Comentarios[0]);
        }

        [Fact]
        public void Tarefa_DeveAdicionarHistorico()
        {
            var historico = new HistoricoAtualizacao { Id = 1, Mudanca = "Atualização 1" };
            var tarefa = new Domain.Entidades.Tarefa();

            tarefa.Historicos.Add(historico);

            Assert.Single(tarefa.Historicos);
            Assert.Equal(historico, tarefa.Historicos[0]);
        }

        [Fact]
        public void Tarefa_DeveAtualizarStatus()
        {
            var tarefa = new Domain.Entidades.Tarefa { Status = "Em Andamento" };

            tarefa.Status = "Concluída";

            Assert.Equal("Concluída", tarefa.Status);
        }
    }
}
