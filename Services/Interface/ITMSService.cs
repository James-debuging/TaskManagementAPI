using TaskManagementAPI.Models;

namespace TaskManagementAPI.Services.Interface
{
    public interface ITMSService
    {
        PagingResult<TMSDto> GetAll(PagingRequest pagingRequest);
        PagingResult<TMSDto> GetTasksByStatus(PagingRequest pagingRequest, string status);
        TMSDto GetById(Guid id);
        TMSDto Create(TMSInsertRequest task);
        bool Update(Guid id, TMSInsertRequest updatedTask);
        bool Delete(Guid id);
    }
}
