using TaskManager.Domain.Entities;

namespace TaskManager.Application.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<Tasks>> GetAllTasksAsync();
        Task<Tasks?> GetTaskByIdAsync(int id);
        Task<Tasks> AddTaskAsync(Tasks task);
        Task<Tasks> UpdateTaskAsync(Tasks task);
        Task<bool> DeleteTaskAsync(int id);
    }
}
