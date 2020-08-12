using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Apis.Controllers
{
    [Route("api/[Controller]")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _repository;

        public TodosController()
        {
            _repository = new TodoRepositoryJson("C:\\temp\\Todos.json");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //return Content("안녕하세요.");
            return Ok(_repository.GetAll());
        }
        [HttpPost]
        public IActionResult Add([FromBody]Todo dto)
        {
            _repository.Add(dto);
            return Ok(dto);
        }
    }
}
