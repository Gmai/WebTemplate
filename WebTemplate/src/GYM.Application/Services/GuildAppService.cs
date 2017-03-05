using GYM.Application.Interfaces;
using System;
using GYM.Application.ViewModel;
using GYM.Domain.Entities;
using AutoMapper;
using System.Collections.Generic;
using GYM.Domain.Interfaces.Service;
using GYM.Infrastructure.Data.Interfaces;
using GYM.Infrastructure.CrossCutting.Utils;

namespace GYM.Application.Services
{
  public class GuildAppService : IGuildAppService
  {
    private readonly IGuildService _guildService;
    private readonly IUnitOfWork _uow;

    public GuildAppService(IGuildService GuildService, IUnitOfWork uow) {
      _guildService = GuildService; 
      _uow = uow;
    }

    public GuildVM Add(GuildVM guildVm)
    {
      var guild = Mapper.Map<GuildVM, Guild>(guildVm);
      ObjectUtils.CheckNullObj(guild);

      _uow.BeginTransaction();
      _guildService.Add(guild);

      _uow.Commit();

      return guildVm;
    }

    public void Dispose()
    {
      _guildService.Dispose();
      GC.SuppressFinalize(this);
    }

    public IEnumerable<GuildVM> GetList()
    {
      return Mapper.Map<IEnumerable<Guild>, IEnumerable<GuildVM>>(_guildService.GetList());
    }

    public GuildVM GetGuildByID(Guid id)
    {
      return Mapper.Map<Guild, GuildVM>(_guildService.GetById(id));
    }

    public void Remove(Guid id)
    {
      _uow.BeginTransaction();
      _guildService.Remove(id);
      _uow.Commit();
    }
  }
}
