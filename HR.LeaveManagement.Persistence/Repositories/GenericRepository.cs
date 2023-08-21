using System;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain.Common;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseDomainEntity
{
    protected readonly HrDatabaseContext _context;

    public GenericRepository(HrDatabaseContext context)
    {
        _context = context;
    }

    public async Task Create(T entity)
    {
        try
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {

        }

    }

    public async Task Delete(T entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _context
            .Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task<IReadOnlyList<T>> GetAll()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task Update(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
}

