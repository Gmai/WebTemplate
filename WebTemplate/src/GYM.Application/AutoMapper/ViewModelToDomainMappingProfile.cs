using GYM.Application.ViewModel;
using AutoMapper;
using GYM.Domain.Entities;
using System;

namespace GYM.Application.AutoMapper
{
  public class ViewModelToDomainMappingProfile : Profile
  {
    public ViewModelToDomainMappingProfile()
    {
      CreateMap<HeroVM, Hero>();
      CreateMap<PetVM, Pet>();
      CreateMap<ItemVM, Item>();
      CreateMap<GuildVM, Guild>();
    }
  }
}




