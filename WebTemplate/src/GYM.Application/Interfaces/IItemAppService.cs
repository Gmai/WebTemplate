using GYM.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace GYM.Application.Interfaces
{
  public interface IItemAppService : IDisposable
  {
    ItemVM Add(ItemVM Item);
    IEnumerable<ItemVM> GetList();
    ItemVM GetItemByID(Guid id);
    void Remove(Guid id);
  }
}
