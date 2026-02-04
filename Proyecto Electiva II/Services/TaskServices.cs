using ActividadEntregable1.Models;
using ActividadEntregable1.Interface;

namespace ActividadEntregable1.Services
{
    public class TaskServices : ITaskServices
    {
        private static List<TaskModel> tasks = new();
        private static int nextId = 1;

        public void AddTask(TaskModel task)
        {
            task.Id = nextId++;
            task.IsCompleted = false;
            tasks.Add(task);
        }

        public List<TaskModel> GetAllTasks()
        {
            return tasks;
        }

        public void UpdateTask(int id, TaskModel task)
        {
            var existing = tasks.FirstOrDefault(t => t.Id == id);
            if (existing == null) return;

            existing.Title = task.Title;
            existing.Description = task.Description;
        }

        public void DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                tasks.Remove(task);
        }

        public void CompleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
                task.IsCompleted = true;
        }
    }
}
