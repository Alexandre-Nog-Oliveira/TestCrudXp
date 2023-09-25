using Microsoft.AspNetCore.Mvc;
using TesteXp.Models;

namespace TesteXp.Controller
{
    public class TarefaController
    {
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly List<TarefaModels> _tarefas = new List<TarefaModels>(); 

        [HttpGet]
        public IActionResult GetTarefas()
        {
            return Ok(_tarefas);
        }

        [HttpGet("{id}")]
        public IActionResult GetTarefa(int id)
        {
            var tarefa = _tarefas.Find(t => t.Id == id);
            if (tarefa == null)
                return NotFound();
            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult CriarTarefa(TarefaModels tarefa)
        {
            tarefa.Id = _tarefas.Count + 1; 
            _tarefas.Add(tarefa);
            return CreatedAtAction(nameof(GetTarefa), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa(int id, TarefaModels tarefaAtualizada)
        {
            var index = _tarefas.FindIndex(t => t.Id == id);
            if (index < 0)
                return NotFound();

            _tarefas[index] = tarefaAtualizada;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarTarefa(int id)
        {
            var tarefa = _tarefas.Find(t => t.Id == id);
            if (tarefa == null)
                return NotFound();

            _tarefas.Remove(tarefa);
            return NoContent();
        }
    }
    }
}