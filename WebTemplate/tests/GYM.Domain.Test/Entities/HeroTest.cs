using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYM.Domain.Entities;
using Rhino.Mocks;
using GYM.Domain.Interfaces.Repository;
using System.Linq;
using System.Collections.Generic;

namespace GYM.Domain.Test.Entities
{
  [TestClass]
  public class HeroTest
  {
    [TestMethod]
    public void Verify_If_Valid()
    {
      Hero hero = new Hero();
      Assert.IsTrue(hero.IsValid());
    }

    [TestMethod]
    public void Verify_If_Exist_True()
    {
      Hero hero = new Hero()
      {
        name = "Shogun",
        isDeleted = false
      };
      List<Hero> listHero = new List<Hero>();
      listHero.Add(hero);

      var stubRepo = MockRepository.GenerateStub<IHeroRepository>();
      stubRepo.Stub(x => x.GetByName(hero.name)).Return(listHero);

      var resultOfSearch = stubRepo.GetByName(hero.name);

      Assert.IsTrue(resultOfSearch.Count()>0);
    }

    [TestMethod]
    public void Verify_If_Exist_False()
    {
      Hero hero = new Hero()
      {
        name = "Shogun",
        isDeleted = false
      };
      List<Hero> listHero = new List<Hero>();

      var stubRepo = MockRepository.GenerateStub<IHeroRepository>();
      stubRepo.Stub(x => x.GetByName(hero.name)).Return(listHero);

      var resultOfSearch = stubRepo.GetByName(hero.name);

      Assert.IsTrue(resultOfSearch.Count()==0);
    }
  }
}
