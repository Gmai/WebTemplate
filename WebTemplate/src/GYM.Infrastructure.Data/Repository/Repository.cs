using GYM.Domain.Interfaces.Repository;
using GYM.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GYM.Infrastructure.Data.Repository
{
  public class Repository<T> : IRepository<T> where T : class
  {
    protected GymContext db;
    protected DbSet<T> dbSet;

    public Repository(GymContext _db)
    {
      db = _db;
      dbSet = db.Set<T>();
    }

    public T Add(T obj)
    {
      var _return = dbSet.Add(obj);
      return _return;
    }

    public void Dispose()
    {
      db.Dispose();
      GC.SuppressFinalize(this);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
      return dbSet.Where(predicate);
    }

    public virtual IEnumerable<T> GetAll()
    {
      return dbSet.ToList();
    }

    public IEnumerable<T> GetAll(int skip, int take)
    {
      return GetAll().Skip(skip).Take(take);
    }

    public T GetById(Guid id)
    {
      return dbSet.Find(id);
    }

    public virtual void Remove(Guid id)
    {
      dbSet.Remove(dbSet.Find(id));
    }

    public int SaveChanges()
    {
      return db.SaveChanges();
    }

    public T Update(T obj)
    {
      var entry = db.Entry(obj);
      dbSet.Attach(obj);
      entry.State = EntityState.Modified;
      return obj;
    }
  }
}
