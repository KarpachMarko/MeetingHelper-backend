﻿using System.ComponentModel.DataAnnotations;
using Base.Domain;

namespace App.Domain;

public class RequirementOption : DomainEntityId
{
    [MaxLength(256)]
    [Display(ResourceType = typeof(Base.Resources.EntityCommon.EntityCommon), Name = "Title")]
    public string Title { get; set; } = default!;

    [MaxLength(2512)]
    [Display(ResourceType = typeof(Base.Resources.EntityCommon.EntityCommon), Name = "Description")]
    public string Description { get; set; } = default!;

    [MaxLength(2512)]
    public string Link { get; set; } = default!;

    public float Price { get; set; }
    
    public Guid RequirementId { get; set; }
    [Required]
    public Requirement? Requirement { get; set; }
}