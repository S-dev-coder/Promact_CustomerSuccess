namespace Promact.CustomerSuccess.Platform.Services.Dtos.AuditHistorys
{
    public class CreateAuditHistoryDto
    {
        public Guid ReviewedBy { get; set; }
        public string Status { get; set; }
        public string ReviewedSection { get; set; }
        public string Comments { get; set; }
        public string ActionItem { get; set; }
    }
}
