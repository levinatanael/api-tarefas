using AutoMapper;
using Tarefa.Application.Dtos;
using Tarefa.Application.Interface;
using Tarefa.Infrastructure.Interface;

namespace Tarefa.Application.Service
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public TarefaService(ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TarefaDto>> ListarTarefasAsync()
        {
            var tarefas = await _tarefaRepository.GetAll();
            return _mapper.Map<IEnumerable<TarefaDto>>(tarefas);
        }

        public async Task<TarefaDto> ObterTarefaPorIdAsync(int id)
        {
            var tarefa = await _tarefaRepository.GetByIdAsync(id);
            return _mapper.Map<TarefaDto>(tarefa);
        }

        public async Task<TarefaDto> CriarTarefaAsync(TarefaDto tarefaDto)
        {
            var tarefa = _mapper.Map<Domain.Entidades.Tarefa>(tarefaDto);
            await _tarefaRepository.AddAsync(tarefa);
            return _mapper.Map<TarefaDto>(tarefa);
        }

        public async Task AtualizarTarefaAsync(TarefaDto tarefaDto)
        {
            var tarefa = _mapper.Map<Domain.Entidades.Tarefa>(tarefaDto);
            await _tarefaRepository.UpdateAsync(tarefa);
        }

        public async Task RemoverTarefaAsync(int id)
        {
            await _tarefaRepository.DeleteAsync(id);
        }
    }
}