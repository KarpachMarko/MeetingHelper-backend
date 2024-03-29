﻿using System.ComponentModel.DataAnnotations;
using App.DAL.DTO.Identity;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.DAL.DTO;

public class Payment : DomainEntityId, IDomainEntityUser<AppUser>
{
    public double Amount { get; set; }
    public DateTime Timestamp { get; set; }

    public Guid RequirementId { get; set; }
    [Required]
    public Requirement? Requirement { get; set; }
    public Guid UserId { get; set; }
    [Required]
    public AppUser? User { get; set; }
}