﻿using App.BLL.DTO;
using App.Contracts.DAL.Repositories;
using Base.Contracts.BLL;

namespace App.Contracts.BLL.Services;

public interface IMeetingService : IEntityUserDependentService<Meeting>, IMeetingRepositoryCustom<Meeting>
{
    
}