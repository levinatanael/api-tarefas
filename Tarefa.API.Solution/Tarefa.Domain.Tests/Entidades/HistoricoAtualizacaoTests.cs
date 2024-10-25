using Tarefa.Domain.Entidades;
using Xunit;

namespace Tarefa.Domain.Tests.Entidades
{
    public class HistoricoAtualizacaoTests
    {
        [Fact]
        public void HistoricoAtualizacao_DeveInicializarComValoresCorretos()
        {
            var historico = new HistoricoAtualizacao();

            Assert.Equal(0, historico.Id);
            Assert.Null(historico.Mudanca);
            Assert.Equal(default, historico.DataAlteracao);
            Assert.Null(historico.Usuario);
        }

        [Fact]
        public void HistoricoAtualizacao_DeveInicializarDataAlteracaoCorretamente()
        {
            var historico = new HistoricoAtualizacao { DataAlteracao = DateTime.Now };

            Assert.True(historico.DataAlteracao <= DateTime.Now);
        }
    }
}
