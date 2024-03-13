using Promact.CustomerSuccess.Platform.Services.Dtos.ProjectBudgets;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Promact.CustomerSuccess.Platform.Entities;

namespace Promact.CustomerSuccess.Platform.Services.ProjectBudgets
{
    public class ProjectBudgetService :
         CrudAppService<ProjectBudget, ProjectBudgetDto, Guid, PagedAndSortedResultRequestDto, CreateProjectBudgetDto, UpdateProjectBudgetDto>,
         IProjectBudgetService
    {
        public ProjectBudgetService(IRepository<ProjectBudget, Guid> repository) : base(repository)
        {
        }
    }
}
