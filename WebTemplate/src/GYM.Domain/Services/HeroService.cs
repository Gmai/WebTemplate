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
  public class HeroService : IHeroService
  {
    private readonly IHeroRepository _heroRepository;

    public HeroService(IHeroRepository heroRepository) {
      _heroRepository = heroRepository;
    }

    public Hero Add(Hero hero)
    {
      return _heroRepository.Add(hero);
    }

    public void Dispose()
    {
      _heroRepository.Dispose();
    }

    public Hero GetById(Guid id)
    {
      return _heroRepository.GetById(id);
    }

    public IEnumerable<Hero> GetList()
    {
      return _heroRepository.GetAll();
    }

    public void Remove(Guid id)
    {
      _heroRepository.Remove(id);
    }
  }
}
