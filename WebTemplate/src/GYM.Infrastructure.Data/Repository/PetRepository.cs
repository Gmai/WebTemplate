using GYM.Domain.Entities;
using GYM.Domain.Interfaces.Repository;
using System;
using System.Linq;
using System.Collections.Generic;
using GYM.Infrastructure.Data.Context;

namespace GYM.Infrastructure.Data.Repository
{
  public class PetRepository : Repository<Pet>, IPetRepository
  {
    public PetRepository(GymContext context):base(context) {
    }

    public IEnumerable<Pet> GetByName(string name)
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

    public override IEnumerable<Pet> GetAll()
    {
      return dbSet.Where(x=>x.Deleted==false).ToList();
    }
  }
}
