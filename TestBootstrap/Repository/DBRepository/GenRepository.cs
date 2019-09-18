using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DiaryAppOlga.Models.DbModels;

namespace DiaryAppOlga.Repository.DBRepository
{
    public class GenRepository<T> : IAsyncSRepository<T> where T : BaseEntity
    {
        private DatabaseContext _dbcontext;

        public GenRepository(DatabaseContext context)
        {
            _dbcontext = context;
        }        

        public async Task<T> AddAsync(T entity)
        {
            _dbcontext.Set<T>().Add(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbcontext.Set<T>().Remove(entity);
            await _dbcontext.SaveChangesAsync();           
        }        

        public virtual async Task<T> GetByIdAsync(int Id)
        {
            return await _dbcontext.Set<T>().FindAsync(Id);
        }

        public async Task<IEnumerable<T>> ListAllAsync1()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }        

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public void Dispose(bool disposing)
        //{
        //    _dbcontext.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}
