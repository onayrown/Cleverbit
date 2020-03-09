using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleverBit.CodingTask.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void LoadDataBaseFromCsv(List<TEntity> listObj);  
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
