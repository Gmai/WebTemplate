using GYM.Application.Interfaces;
using System;
using GYM.Application.ViewModel;
using GYM.Domain.Entities;
using AutoMapper;
using System.Collections.Generic;
using GYM.Domain.Interfaces.Service;
using GYM.Infrastructure.Data.Interfaces;

namespace GYM.Application
{
  public class HeroAppService : IHeroAppService
  {
    private readonly IHeroService _heroService;
    private readonly IUnitOfWork _uow;

    public HeroAppService(IHeroService heroService, IUnitOfWork uow) {
      _heroService = heroService; 
      _uow = uow;
    }

    public HeroVM Add(HeroVM heroVm)
    {
      var hero = Mapper.Map<HeroVM, Hero>(heroVm);

      _uow.BeginTransaction();
      _heroService.Add(hero);

      _uow.Commit();

      return heroVm;
    }

    public void Dispose()
    {
      _heroService.Dispose();
      GC.SuppressFinalize(this);
    }

    public IEnumerable<HeroVM> GetList()
    {
      return Mapper.Map<IEnumerable<Hero>, IEnumerable<HeroVM>>(_heroService.GetList());
    }

    public HeroVM GetHeroByID(Guid id)
    {
      return Mapper.Map<Hero, HeroVM>(_heroService.GetById(id));
    }

    public void Remove(Guid id)
    {
      _heroService.Remove(id);
    }
  }
}
