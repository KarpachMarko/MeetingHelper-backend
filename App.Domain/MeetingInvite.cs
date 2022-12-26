﻿using System.ComponentModel.DataAnnotations;
using App.Domain.Enums;
using App.Domain.Identity;
using Base.Contracts.Domain;
using Base.Domain;

namespace App.Domain;

public class MeetingInvite : DomainEntityId, IDomainEntityUser<AppUser>
{
    public EInviteStatus? Status { get; set; }
    
    public Guid MeetingId { get; set; }
    public Meeting? Meeting { get; set; }
    
    public Guid UserId { get; set; }
    public AppUser? User { get; set; }
}