using System.Collections.Concurrent;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Data
{
    public class InMemoryTaskStore
    {
        private readonly ConcurrentDictionary<int, TaskItem> _tasks = new();
        private int _nextId = 1;

        public IEnumerable<TaskItem> GetAllTasks(string userId) => 
            _tasks.Values.Where(task => task.UserId == userId); 

        public TaskItem GetTaskById(int id) => _tasks.GetValueOrDefault(id); // Treba da se dodade exception handling tuka

        public TaskItem CreateTask(TaskItem task, string userId) 
        {
            task.Id = _nextId++;
            task.UserId = userId; 
            _tasks[task.Id] = task;
            return task;
        }

        public bool UpdateTask(TaskItem task)
        {
            if (!_tasks.ContainsKey(task.Id)) return false;
            _tasks[task.Id] = task;
            return true;
        }

        public bool DeleteTask(int id) => _tasks.TryRemove(id, out _);
    }
}