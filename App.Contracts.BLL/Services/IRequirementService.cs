﻿using App.BLL.DTO;
using App.Contracts.DAL.Repositories;
using Base.Contracts.BLL;
using Base.Contracts.DAL;

namespace App.Contracts.BLL.Services;

public interface IRequirementService : IEntityUserDependentRepository<Requirement>, IRequirementRepositoryCustom<Requirement>
{
    
}