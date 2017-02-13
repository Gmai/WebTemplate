using GYM.Domain.Entities;
using GYM.Domain.Interfaces.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GYM.Infra.Data.Repository
{
  public class HeroRepository : Repository<Hero>, IHeroRepository
  {
    public IEnumerable<Hero> GetByName(string name)
    {
      return dbSet.Where(x => x.name == name).ToList();
    }

    public override void Remove(Guid id)
    {
      var obj = dbSet.Find(id);
      obj.isDeleted = true;
      obj.deletedOn = DateTime.Now;
      Update(obj);
    }
  }
}
