using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiaryAppOlga.Models.DbModels;


namespace DiaryAppOlga.Repository.DBRepository
{
    public interface IAsyncSRepository<T> : IDisposable where T: BaseEntity
    {
        Task<T> GetByIdAsync(int Id);  

        Task<IEnumerable<T>> ListAllAsync1();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);        
        Task DeleteAsync(T entity);        
       




    }
}
