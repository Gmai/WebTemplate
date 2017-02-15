using Application.Interfaces;
using System;
using Application.ViewModel;
using GYM.Infra.Data.Repository;
using GYM.Domain.Entities;
using AutoMapper;
using System.Collections.Generic;
using GYM.Domain.Interfaces.Service;

namespace Application
{
  public class HeroAppService : IHeroAppService
  {
    private readonly IHeroService _heroService;

    public HeroAppService(IHeroService heroService)
    {
      _heroService = heroService;
    }

    public HeroVM Add(HeroVM heroVm)
    {
      var hero = Mapper.Map<HeroVM, Hero>(heroVm);
      _heroService.Add(hero);
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
