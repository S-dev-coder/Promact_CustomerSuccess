

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistorys;

namespace Promact.CustomerSuccess.Platform.Services.AuditHistorys
{

    public class AuditHistoryService :
    CrudAppService<AuditHistory, AuditHistoryDto, Guid, PagedAndSortedResultRequestDto, CreateAuditHistoryDto, UpdateAuditHistoryDto>,
    IAuditHistoryService
    {
        public AuditHistoryService(IRepository<AuditHistory, Guid> repository) : base(repository)
        {
        }
    }
}
