using ActividadEntregable1.Models;

namespace ActividadEntregable1.Interface
{
    public interface ITaskServices
    {
        void AddTask(TaskModel task);
        List<TaskModel> GetAllTasks();
        void UpdateTask(int id, TaskModel task);
        void DeleteTask(int id);
        void CompleteTask(int id);
    }
}
