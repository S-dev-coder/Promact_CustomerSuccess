﻿using Promact.CustomerSuccess.Platform.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.Sprints
{
    public class SprintDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid PhaseMilestoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SprintStatus Status { get; set; }
        public required string Comments { get; set; }
        public required string Goals { get; set; }
        public int SprintNumber { get; set; }
        public virtual PhaseMilestone? PhaseMilestone { get; set; }
    }
}
