using System;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> Get(int id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
}

