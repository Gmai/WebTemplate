

using GYM.Application.Interfaces;
using GYM.Application.Services;
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
      container.Register<IGuildAppService, GuildAppService>(Lifestyle.Scoped);
      container.Register<IPetAppService, PetAppService>(Lifestyle.Scoped);
      container.Register<IItemAppService, ItemAppService>(Lifestyle.Scoped);

      //Domain
      container.Register<IHeroService, HeroService>(Lifestyle.Scoped);
      container.Register<IPetService, PetService>(Lifestyle.Scoped);
      container.Register<IGuildService, GuildService>(Lifestyle.Scoped);
      container.Register<IItemService, ItemService>(Lifestyle.Scoped);

      //Infra data
      container.Register<IHeroRepository, HeroRepository>(Lifestyle.Scoped);
      container.Register<IPetRepository, PetRepository>(Lifestyle.Scoped);
      container.Register<IGuildRepository, GuildRepository>(Lifestyle.Scoped);
      container.Register<IItemRepository, ItemRepository>(Lifestyle.Scoped);
      container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

      container.Register<GymContext>(Lifestyle.Scoped);

      //container.Register(typeof(IRepository<>), typeof(Repository<>)); to register generic 
    }
  }
}
