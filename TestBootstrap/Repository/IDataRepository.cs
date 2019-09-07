using System;
using System.Collections.Generic;


namespace DiaryAppOlga.Repository
{
    interface IDataRepository<T> where T : class
    {
        IEnumerable<T> ListAll { get; }
        T GetById (int key);
        void Add (T item);
        void Update (T item);
        void Delete (T item);

    }
}
