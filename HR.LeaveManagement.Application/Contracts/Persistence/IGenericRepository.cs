using System;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : BaseDomainEntity
{
    Task<IReadOnlyList<T>> GetAll();
    Task<T> GetById(int id);
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}

