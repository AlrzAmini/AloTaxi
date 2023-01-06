using AloTaxi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Data.Context;
using AloTaxi.Domain.Interfaces;

namespace AloTaxi.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AloTaxiDbContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(AloTaxiDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsList()
        {
            return await _entities.ToListAsync();
        }

        public IQueryable<T> GetAllAsQueryable()
        {
            return _entities.AsQueryable();
        }

        public async Task<T?> GetById(long id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
            await Save();
        }

        public async Task Update(T entity)
        {
            entity.ModifiedDate = DateTime.Now;

            _entities.Update(entity);
            await Save();
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                entity.IsDeleted = true;
                await Update(entity);
                return true;
            }
            catch (Exception e)
            {
                // log error
                return false;
            }
        }

        public async Task<bool> Delete(long id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            return await Delete(entity);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
