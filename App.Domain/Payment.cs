﻿using System.ComponentModel.DataAnnotations;
using App.Domain.Identity;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.Domain;

public class Payment : DomainEntityId, IDomainEntityUser<AppUser>
{
    public double Amount { get; set; }
    public DateTime Timestamp { get; set; }

    public Guid RequirementId { get; set; }
    public Requirement? Requirement { get; set; }
    public Guid UserId { get; set; }
    public AppUser? User { get; set; }
}