﻿using GYM.Domain.Entities;
using GYM.Domain.Interfaces.Repository;
using System;
using System.Linq;
using System.Collections.Generic;
using GYM.Infrastructure.Data.Context;

namespace GYM.Infrastructure.Data.Repository
{
  public class HeroRepository : Repository<Hero>, IHeroRepository
  {
    public HeroRepository(GymContext context):base(context) {
    }

    public IEnumerable<Hero> GetByName(string name)
    {
      return dbSet.Where(x => x.Name == name).ToList();
    }

    public override void Remove(Guid id)
    {
      var obj = dbSet.Find(id);
      obj.Deleted = true;
      obj.DeletedOn = DateTime.Now;
      Update(obj);
    }

    public override IEnumerable<Hero> GetAll()
    {
      return dbSet.Where(x=>x.Deleted==false).ToList();
    }
  }
}
