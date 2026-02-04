using ActividadEntregable1.Interface;
using ActividadEntregable1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActividadEntregable1.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskServices _taskServices;

        public TaskController(ITaskServices taskServices)
        {
            _taskServices = taskServices;
        }

        // POST: api/tasks
        [HttpPost]
        public IActionResult AddTask([FromBody] TaskModel task)
        {
            _taskServices.AddTask(task);
            return Ok(new
            {
                mensaje = "Tarea creada exitosamente",
                tarea = task
            });
        }

        // GET: api/tasks
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            return Ok(_taskServices.GetAllTasks());
        }

        // PUT: api/tasks/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskModel task)
        {
            _taskServices.UpdateTask(id, task);
            return Ok("Tarea actualizada correctamente");
        }

        // DELETE: api/tasks/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            _taskServices.DeleteTask(id);
            return Ok("Tarea eliminada correctamente");
        }

        // PATCH: api/tasks/{id}/completar
        [HttpPatch("{id}/completar")]
        public IActionResult CompleteTask(int id)
        {
            _taskServices.CompleteTask(id);
            return Ok("Tarea marcada como completada");
        }
    }
}

