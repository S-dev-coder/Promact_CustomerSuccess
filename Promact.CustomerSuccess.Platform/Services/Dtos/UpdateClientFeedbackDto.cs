using Promact.CustomerSuccess.Platform;
using System.ComponentModel.DataAnnotations.Schema;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class UpdateClientFeedbackDto
    {
        public Guid ProjectId { get; set; }

        public FeedbackType FeedbackType { get; set; }
        public required string DetailedFeedback { get; set; }
        public bool ActionTaken { get; set; }

        public DateTime? ClosureDate { get; set; }

    }
}