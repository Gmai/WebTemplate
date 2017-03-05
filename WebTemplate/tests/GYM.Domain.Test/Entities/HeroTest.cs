using System;
using GYM.Domain.Entities;
using Rhino.Mocks;
using GYM.Domain.Interfaces.Repository;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace GYM.Domain.Test.Entities
{
  [TestFixture]
  public class HeroTest
  {
    [Test]
    public void Verify_If_Valid()
    {
      Hero hero = new Hero();
      Assert.IsTrue(hero.IsValid());
    }

    [Test]
    public void Try_to_insert()
    {
      Hero hero = new Hero()
      {
        Name = "SHOGUNMOCK",
        CreatedOn = DateTime.Now,
        Deleted = false
      };

      var stubRepo = MockRepository.GenerateStub<IHeroRepository>();
      stubRepo.Stub(x => x.Add(hero)).Return(hero);

      var heroInserted = stubRepo.Add(hero);

      Assert.IsTrue(heroInserted.HeroId!=null);
    }

    [Test]
    public void Verify_If_Exist_True()
    {
      Hero hero = new Hero()
      {
        Name = "Shogun",
        Deleted = false
      };
      List<Hero> listHero = new List<Hero>();
      listHero.Add(hero);

      var stubRepo = MockRepository.GenerateStub<IHeroRepository>();
      stubRepo.Stub(x => x.GetByName(hero.Name)).Return(listHero);

      var resultOfSearch = stubRepo.GetByName(hero.Name);

      Assert.IsTrue(resultOfSearch.Count() > 0);
    }

    [Test]
    public void Verify_If_Exist_False()
    {
      Hero hero = new Hero()
      {
        Name = "Shogun",
        Deleted = false
      };
      List<Hero> listHero = new List<Hero>();

      var stubRepo = MockRepository.GenerateStub<IHeroRepository>();
      stubRepo.Stub(x => x.GetByName(hero.Name)).Return(listHero);

      var resultOfSearch = stubRepo.GetByName(hero.Name);

      Assert.IsTrue(resultOfSearch.Count()==0);
    }
  }
}
