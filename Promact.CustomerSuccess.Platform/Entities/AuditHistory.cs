﻿using Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Entities;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class AuditHistory : AuditedEntity<Guid>
    {
        public DateTime DateOfAudit { get; set; }
        public Guid ReviewedBy { get; set; }
        public string Status { get; set; }
        public string ReviewedSection { get; set; }
        public string Comments { get; set; }
        public string ActionItem { get; set; }
    }
}


