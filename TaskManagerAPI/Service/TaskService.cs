using TaskManagerAPI.Data;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Service
{
    public class TaskService
    {
        private readonly InMemoryTaskStore _taskStore;

        public TaskService(InMemoryTaskStore taskStore)
        {
            _taskStore = taskStore;
        }
        public IEnumerable<TaskItem> GetAllTasks(string userId) => _taskStore.GetAllTasks(userId);

        public TaskItem GetTaskById(int id) => _taskStore.GetTaskById(id);
        public TaskItem CreateTask(TaskItem task, string userId) => _taskStore.CreateTask(task, userId);
        public bool UpdateTask(TaskItem task) => _taskStore.UpdateTask(task);
        public bool DeleteTask(int id) => _taskStore.DeleteTask(id);
    }
}