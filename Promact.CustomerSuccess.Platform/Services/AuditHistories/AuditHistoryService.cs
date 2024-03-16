﻿using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistories;


namespace Promact.CustomerSuccess.Platform.Services.AuditHistories
{

    public class AuditHistoryService : 
        CrudAppService<
            AuditHistory, 
            AuditHistoryDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateAuditHistoryDto, 
            UpdateAuditHistoryDto>, 
        IAuditHistoryService
    {
        public AuditHistoryService(IRepository<AuditHistory, Guid> repository) : base(repository)
        {
        }
    }
}
