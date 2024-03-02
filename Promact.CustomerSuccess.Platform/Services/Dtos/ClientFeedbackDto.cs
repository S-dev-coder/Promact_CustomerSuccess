﻿using Volo.Abp.Application.Dtos;

namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class ClientFeedbackDto: IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public FeedbackType FeedbackType { get; set; }
        public required string DetailedFeedback { get; set; }
        public bool ActionTaken { get; set; }
        public DateTime? ClosureDate { get; set; }
    }
}
