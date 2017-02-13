using Application.ViewModel;
using AutoMapper;
using GYM.Domain.Entities;
using System;

namespace Application.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
  {
    public DomainToViewModelMappingProfile()
    {
      CreateMap<Hero, HeroVM>();
    }
  }
}
