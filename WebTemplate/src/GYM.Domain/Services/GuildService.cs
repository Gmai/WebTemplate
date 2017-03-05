using GYM.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYM.Domain.Entities;
using GYM.Domain.Interfaces.Repository;

namespace GYM.Domain.Services
{
  public class GuildService : IGuildService
  {
    private readonly IGuildRepository _guildRepository;

    public GuildService(IGuildRepository guildRepository) {
      _guildRepository = guildRepository;
    }

    public Guild Add(Guild guild)
    {
      return _guildRepository.Add(guild);
    }

    public void Dispose()
    {
      _guildRepository.Dispose();
    }

    public Guild GetById(Guid id)
    {
      return _guildRepository.GetById(id);
    }

    public IEnumerable<Guild> GetList()
    {
      return _guildRepository.GetAll();
    }

    public void Remove(Guid id)
    {
      _guildRepository.Remove(id);
    }
  }
}
