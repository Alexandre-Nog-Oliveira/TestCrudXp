using TesteXp.Models;

namespace TesteXp.Infrastructure.Repositories
{
    public class TarefaRepository
    {
         private readonly List<TarefaModels> _tarefas = new List<TarefaModels>();
        public List<TarefaModels> ObterTodasTarefas()
        {
            return _tarefas;
        }

        public TarefaModels ObterTarefaPorId(int id)
        {
            return _tarefas.Find(t => t.Id == id);
        }

        public void AdicionarTarefa(TarefaModels tarefa)
        {
            tarefa.Id = _tarefas.Count + 1; 
            _tarefas.Add(tarefa);
        }
    }
}