using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GYM.Domain.Interfaces.Repository
{
  public interface IRepository<T> : IDisposable where T : class
  {
    T Add(T obj);
    T GetById(Guid id);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAll(int skip, int take);
    T Update(T obj);
    void Remove(Guid id);
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    int SaveChanges();
  }
}
