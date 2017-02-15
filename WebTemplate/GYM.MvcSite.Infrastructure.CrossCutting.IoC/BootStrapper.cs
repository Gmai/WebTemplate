using Application;
using Application.Interfaces;
using GYM.Domain.Interfaces.Repository;
using GYM.Domain.Interfaces.Service;
using GYM.Domain.Services;
using GYM.Infra.Data.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.MvcSite.Infrastructure.CrossCutting.IoC
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
