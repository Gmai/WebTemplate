using GYM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Domain.Interfaces.Repository
{
  public interface IHeroRepository : IRepository<Hero>
  {
    IEnumerable<Hero> GetByName(string name);
  }
}
