using Tarefa.Domain.Entidades;
using Xunit;

namespace Tarefa.Domain.Tests.Entidades
{
    public class ComentarioTests
    {
        [Fact]
        public void Comentario_DeveInicializarComValoresCorretos()
        {
            var comentario = new Comentario();

            Assert.Equal(0, comentario.Id);
            Assert.Null(comentario.Conteudo);
            Assert.Equal(default, comentario.DataCriacao);
        }

        [Fact]
        public void Comentario_DeveInicializarDataCriacaoCorretamente()
        {
            var comentario = new Comentario { DataCriacao = DateTime.Now };

            Assert.True(comentario.DataCriacao <= DateTime.Now);
        }
    }
}
