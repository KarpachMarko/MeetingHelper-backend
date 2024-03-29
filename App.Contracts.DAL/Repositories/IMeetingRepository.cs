﻿using App.DAL.DTO;
using Base.Contracts.DAL;
using Base.Contracts.Domain;

namespace App.Contracts.DAL.Repositories;

public interface IMeetingRepository : IEntityUserDependentRepository<Meeting>, IMeetingRepositoryCustom<Meeting>
{
    
}

public interface IMeetingRepositoryCustom<TEntity>
    where TEntity : IDomainEntityId
{
    
}