using GYM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Domain.Interfaces.Service
{
  public interface IGuildService:IDisposable {
    Guild Add(Guild guild);
    IEnumerable<Guild> GetList();
    Guild GetById(Guid id);
    void Remove(Guid id);
  }
}
