﻿using System.ComponentModel.DataAnnotations;

namespace Promact.CustomerSuccess.Platform.Services.Dtos.Projects
{
    public class CreateProjectDto
    {
        [Required]
        [StringLength(128)]
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}