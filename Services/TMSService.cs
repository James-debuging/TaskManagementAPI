using TaskManagementAPI.Data;
using TaskManagementAPI.Models;
using TaskManagementAPI.Services.Interface;

namespace TaskManagementAPI.Services
{
    public class TMSService : ITMSService
    {
        private readonly List<TMSDto> _tasks = DummyTMSData.GetDummyTasks();

        public PagingResult<TMSDto> GetAll(PagingRequest pagingRequest)
        {
            return new PagingResult<TMSDto>(_tasks, pagingRequest.PageNumber, pagingRequest.PageSize);
        }

        public PagingResult<TMSDto> GetTasksByStatus(PagingRequest pagingRequest, string status)
        {
            var tasks = _tasks.Where(x => x.Status == status);
            return new PagingResult<TMSDto>(tasks, pagingRequest.PageNumber, pagingRequest.PageSize);
        }

        public TMSDto GetById(Guid id) => _tasks.FirstOrDefault(t => t.Id == id) ??
            throw new Exception("Task Management is not found.");

        public TMSDto Create(TMSInsertRequest task)
        {
            var tmsInsert = new TMSDto()
            {
                Id = Guid.NewGuid(),
                Title = task.Title,
                Description = task.Description,
                Status = task.Status,
                Type = task.Type,
            };
            _tasks.Add(tmsInsert);
            return tmsInsert;
        }

        public bool Update(Guid id, TMSInsertRequest updatedTask)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Title = updatedTask.Title;
            existing.Description = updatedTask.Description;
            existing.Status = updatedTask.Status;
            existing.Type = updatedTask.Type;
            return true;
        }

        public bool Delete(Guid id)
        {
            var task = GetById(id);
            if (task == null) return false;

            _tasks.Remove(task);
            return true;
        }
    }
}
