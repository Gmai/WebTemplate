

using GYM.Application;
using GYM.Application.Interfaces;
using GYM.Domain.Interfaces.Repository;
using GYM.Domain.Interfaces.Service;
using GYM.Domain.Services;
using GYM.Infrastructure.Data.Repository;
using SimpleInjector;

namespace GYM.Infrastructure.CrossCutting.IoC
{
  public class BootStrapper
  {
    public static void Register(Container container)
    {
      //App
      container.Register<IHeroAppService, HeroAppService>();

      //Domain
      container.Register<IHeroService, HeroService>();

      //Infra data
      container.Register<IHeroRepository, HeroRepository>();
      //container.Register(typeof(IRepository<>), typeof(Repository<>)); to register generic 
    }
  }
}
