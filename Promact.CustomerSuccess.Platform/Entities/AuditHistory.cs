using Volo.Abp.Domain.Entities;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class AuditHistory : Entity<Guid>
    {
        public int Id { get; set; }
        public string DateOfAudit { get; set; }
        public string ReviewedBy { get; set; }
        public string Status { get; set; }
        public string ReviewedSection { get; set; }
        public DateTime Comments { get; set; }
        public string ActionItem { get; set; }
    }
}


