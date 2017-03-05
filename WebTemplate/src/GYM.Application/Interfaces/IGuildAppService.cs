using GYM.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace GYM.Application.Interfaces
{
  public interface IGuildAppService : IDisposable
  {
    GuildVM Add(GuildVM Guild);
    IEnumerable<GuildVM> GetList();
    GuildVM GetGuildByID(Guid id);
    void Remove(Guid id);
  }
}
