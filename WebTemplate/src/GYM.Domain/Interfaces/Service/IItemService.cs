using GYM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Domain.Interfaces.Service
{
  public interface IItemService:IDisposable {
    Item Add(Item item);
    IEnumerable<Item> GetList();
    Item GetById(Guid id);
    void Remove(Guid id);
  }
}
