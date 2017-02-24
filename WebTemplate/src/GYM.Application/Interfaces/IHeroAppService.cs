using GYM.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace GYM.Application.Interfaces
{
  public interface IHeroAppService : IDisposable
  {
    HeroVM Add(HeroVM hero);
    IEnumerable<HeroVM> GetList();
    HeroVM GetHeroByID(Guid id);
    void Remove(Guid id);
  }
}
