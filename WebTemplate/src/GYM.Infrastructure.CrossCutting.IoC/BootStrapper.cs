

using GYM.Application;
using GYM.Application.Interfaces;
using GYM.Domain.Interfaces.Repository;
using GYM.Domain.Interfaces.Service;
using GYM.Domain.Services;
using GYM.Infrastructure.Data.Context;
using GYM.Infrastructure.Data.Interfaces;
using GYM.Infrastructure.Data.Repository;
using GYM.Infrastructure.Data.UoW;
using SimpleInjector;

namespace GYM.Infrastructure.CrossCutting.IoC
{
  public class BootStrapper
  {
    public static void Register(Container container)
    {
      //App
      container.Register<IHeroAppService, HeroAppService>(Lifestyle.Scoped);

      //Domain
      container.Register<IHeroService, HeroService>(Lifestyle.Scoped);

      //Infra data
      container.Register<IHeroRepository, HeroRepository>(Lifestyle.Scoped);
      container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

      container.Register<GymContext>(Lifestyle.Scoped);

      //container.Register(typeof(IRepository<>), typeof(Repository<>)); to register generic 
    }
  }
}
