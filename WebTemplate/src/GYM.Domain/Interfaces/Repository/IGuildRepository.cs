using GYM.Domain.Entities;
using System.Collections.Generic;
namespace GYM.Domain.Interfaces.Repository
{
  public interface IGuildRepository : IRepository<Guild>
  {
    IEnumerable<Guild> GetByName(string name);
  }
}
