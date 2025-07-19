using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Models;
using TaskManagementAPI.Services.Interface;

namespace TaskManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TMSController : ControllerBase
    {
        private readonly ITMSService _service;

        public TMSController(ITMSService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] PagingRequest pagingRequest) 
        { 
            var result = _service.GetAll(pagingRequest);
            return Ok(result);
        }

        [HttpGet("GetTasksByStatus")]
        public IActionResult GetTasksByStatus([FromQuery] PagingRequest pagingRequest, string status)
        {
            var result = _service.GetTasksByStatus(pagingRequest, status);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var task = _service.GetById(id);
            return task == null ? NotFound() : Ok(task);
        }

        [HttpPost]
        public IActionResult Create(TMSInsertRequest task)
        {
            var created = _service.Create(task);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, TMSInsertRequest task)
        {
            var success = _service.Update(id, task);
            return success ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var success = _service.Delete(id);
            return success ? Ok() : NotFound();
        }
    }
}
