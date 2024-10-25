using Microsoft.AspNetCore.Mvc;
using Tarefa.Application.Service;
using Tarefa.Domain.Entidades;

namespace Tarefa.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoService _projetoService;

        public ProjetosController(ProjetoService projetoService)
        {
            _projetoService = projetoService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarProjetos()
        {
            var projetos = await _projetoService.ListarProjetosAsync();
            return Ok(projetos);
        }

        [HttpPost]
        public async Task<IActionResult> CriarProjeto([FromBody] Projeto projeto)
        {
            await _projetoService.CriarProjetoAsync(projeto);
            return CreatedAtAction(nameof(ListarProjetos), new { id = projeto.Id }, projeto);
        }
    }
}
