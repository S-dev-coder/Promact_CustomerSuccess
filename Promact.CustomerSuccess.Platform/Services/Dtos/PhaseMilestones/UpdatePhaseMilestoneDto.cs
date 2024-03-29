﻿using Promact.CustomerSuccess.Platform.Entities;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.PhaseMilestones
{
    public class UpdatePhaseMilestoneDto
    {
        public Guid ProjectId { get; set; }
        public required string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public required string Description { get; set; }
        public required string Comments { get; set; }
        public MilestoneOrPhaseStatus Status { get; set; }
    }
}
