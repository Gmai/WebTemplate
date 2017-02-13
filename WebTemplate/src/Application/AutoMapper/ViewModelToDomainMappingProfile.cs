using Application.ViewModel;
using AutoMapper;
using GYM.Domain.Entities;
using System;

namespace Application.AutoMapper
{
  public class ViewModelToDomainMappingProfile : Profile
  {
    public ViewModelToDomainMappingProfile()
    {
      CreateMap<HeroVM, Hero>();
    }
  }
}
