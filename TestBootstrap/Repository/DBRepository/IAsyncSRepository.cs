using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiaryAppOlga.Models;


namespace Microsoft.DiaryAppOlga.ApplicationCore.Interfaces
{
    public interface IAsyncSRepository<T> : IDisposable where T:BaseEntity/*, IAggregateRoot*/
    {
        Task<T> GetByIdAsync(int id);
        //Task<IReadOnlyList<T>> ListAllAsync();

        Task<IEnumerable<T>> ListAllAsync1();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);        
        Task DeleteAsync(T entity);        
        //???
       // Task SaveAsync(T entity);




    }
}
