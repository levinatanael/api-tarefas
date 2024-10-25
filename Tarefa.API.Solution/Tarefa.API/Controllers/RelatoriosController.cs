using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarefa.Application.Service;

namespace Tarefa.API.Controllers
{
    [Authorize(Roles = "Gerente")]
    [Route("api/[controller]")]
    public class RelatoriosController : ControllerBase
    {
        private readonly RelatorioService _relatorioService;

        public RelatoriosController(RelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpGet("media-tarefas-concluidas")]
        public async Task<IActionResult> ObterMediaTarefasConcluidas()
        {
            var media = await _relatorioService.ObterMediaTarefasConcluidasAsync(30);
            return Ok(new { media });
        }
    }
}
