using GYM.Application.ViewModel;
using AutoMapper;
using GYM.Domain.Entities;
using System;

namespace GYM.Application.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public DomainToViewModelMappingProfile()
    {
      CreateMap<Hero, HeroVM>();
      CreateMap<Pet, PetVM>();
      CreateMap<Item, ItemVM>();
      CreateMap<Guild, GuildVM>();
    }
  }
}


