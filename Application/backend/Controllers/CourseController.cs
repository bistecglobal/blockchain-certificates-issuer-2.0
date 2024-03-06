using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _todoService;
        public CourseController(ICourseServices todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sqlQuery = "SELECT * FROM c";
            var result = await _todoService.GetTasks(sqlQuery);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Courses task)
        {
            task.id = Guid.NewGuid().ToString();
            var result = await _todoService.AddTask(task);

            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Courses task)
        {
            var result = await _todoService.UpdateTask(task);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id, string
        partition)
        {
            await _todoService.DeleteTask(id, partition);
            return Ok();
        }
    }
}
