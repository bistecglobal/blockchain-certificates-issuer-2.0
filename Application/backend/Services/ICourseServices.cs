using backend.Models;


namespace backend.Services
{
    public interface ICourseServices
    {
        Task<List<Courses>> GetTasks(string cosmosQuery);
        Task<Courses> AddTask(Courses task);
        Task<Courses> UpdateTask(Courses task);
        Task DeleteTask(string id, string partition);
    }
}
