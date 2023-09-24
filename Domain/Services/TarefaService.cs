using TesteXp.Infrastructure.Repositories;
using TesteXp.Models;

namespace TesteXp.Domain.Services
{
    public class TarefaService
    {
         private readonly TarefaRepository _tarefaRepository;

        public TarefaService(TarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository ?? throw new ArgumentNullException(nameof(tarefaRepository));
        }

        public List<TarefaModels> ObterTodasTarefas()
        {
            return _tarefaRepository.ObterTodasTarefas();
        }

        public TarefaModels ObterTarefaPorId(int id)
        {
            return _tarefaRepository.ObterTarefaPorId(id);
        }

        public void CriarTarefa(TarefaModels tarefa)
        {
            _tarefaRepository.AdicionarTarefa(tarefa);
        }

    }
}