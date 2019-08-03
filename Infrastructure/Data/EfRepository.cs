using Microsoft.DiaryAppOlga.ApplicationCore.Entities;
using Microsoft.DiaryAppOlga.ApplicationCore.Interfaces;
using Microsoft.DiaryAppOlga.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {

        protected readonly ScheduleContext _dbContext;

        public EfRepository(ScheduleContext dbContext)
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param Write implementation!></param>
        /// <returns></returns>
        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
