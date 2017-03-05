using GYM.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace GYM.Application.Interfaces
{
  public interface IPetAppService : IDisposable
  {
    PetVM Add(PetVM Pet);
    IEnumerable<PetVM> GetList();
    PetVM GetPetByID(Guid id);
    void Remove(Guid id);
  }
}
