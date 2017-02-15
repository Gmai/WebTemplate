using GYM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Domain.Interfaces.Service
{
  public interface IHeroService:IDisposable {
    Hero Add(Hero hero);
    IEnumerable<Hero> GetList();
    Hero GetById(Guid id);
    void Remove(Guid id);
  }
}
