using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistorys
{
    public class AuditHistoryDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DateOfAudit { get; set; } = DateTime.Now;
        public Guid ReviewedBy { get; set; }
        public string Status { get; set; }
        public string ReviewedSection { get; set; }
        public string Comments { get; set; }
        public string ActionItem { get; set; }

    }
}
