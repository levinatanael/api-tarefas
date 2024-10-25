using Microsoft.AspNetCore.Mvc;
using Tarefa.Application.Dtos;
using Tarefa.Application.Interface;

namespace Tarefa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        // GET: api/tarefa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TarefaDto>>> GetTarefas()
        {
            var tarefas = await _tarefaService.ListarTarefasAsync();
            return Ok(tarefas);
        }

        // GET: api/tarefa/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaDto>> GetTarefa(int id)
        {
            var tarefa = await _tarefaService.ObterTarefaPorIdAsync(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        // POST: api/tarefa
        [HttpPost]
        public async Task<ActionResult<TarefaDto>> PostTarefa([FromBody] TarefaDto tarefaDto)
        {
            var tarefaCriada = await _tarefaService.CriarTarefaAsync(tarefaDto);
            return CreatedAtAction(nameof(GetTarefa), new { id = tarefaCriada.Id }, tarefaCriada);
        }

        // PUT: api/tarefa/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarefa(int id, [FromBody] TarefaDto tarefaDto)
        {
            if (id != tarefaDto.Id)
            {
                return BadRequest();
            }

            await _tarefaService.AtualizarTarefaAsync(tarefaDto);
            return NoContent();
        }

        // DELETE: api/tarefa/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarefa(int id)
        {
            await _tarefaService.RemoverTarefaAsync(id);
            return NoContent();
        }
    }
}
