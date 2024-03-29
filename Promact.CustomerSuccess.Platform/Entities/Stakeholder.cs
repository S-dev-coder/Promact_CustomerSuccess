﻿using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Promact.CustomerSuccess.Platform.Entities
{
    public class Stakeholder : AuditedEntity<Guid>
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        [ForeignKey(nameof(Project))]
        public Guid ProjectId { get; set; }
        public virtual Project? Project { get; set; }
    }
}
