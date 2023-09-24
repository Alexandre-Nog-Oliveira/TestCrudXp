using TesteXp.Domain.Services;
using TesteXp.Infrastructure.Repositories;
using TesteXp.Models;
using Xunit;


namespace MinhaApiDeTarefas.Tests
{
    public class TarefaServiceTests
    {
        [Fact]
        public void ObterTodasTarefas_DeveRetornarTarefas()
        {
            var repository = new TarefaRepository();
            repository.AdicionarTarefa(new TarefaModels { Id = 1, Title = "Tarefa 1", Completed = false });
            var service = new TarefaService(repository);

            var tarefas = service.ObterTodasTarefas();

            Assert.NotNull(tarefas);
            Assert.Equal(1, tarefas.Count);
        }
    }
}
