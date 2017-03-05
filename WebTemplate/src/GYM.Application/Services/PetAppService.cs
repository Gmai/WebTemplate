using GYM.Application.Interfaces;
using System;
using GYM.Application.ViewModel;
using GYM.Domain.Entities;
using AutoMapper;
using System.Collections.Generic;
using GYM.Domain.Interfaces.Service;
using GYM.Infrastructure.Data.Interfaces;
using GYM.Infrastructure.CrossCutting.Utils;

namespace GYM.Application.Services
{
  public class PetAppService : IPetAppService
  {
    private readonly IPetService _petService;
    private readonly IUnitOfWork _uow;

    public PetAppService(IPetService PetService, IUnitOfWork uow) {
      _petService = PetService; 
      _uow = uow;
    }

    public PetVM Add(PetVM petVm)
    {
      var pet = Mapper.Map<PetVM, Pet>(petVm);
      ObjectUtils.CheckNullObj(pet);

      _uow.BeginTransaction();
      _petService.Add(pet);

      _uow.Commit();

      return petVm;
    }

    public void Dispose()
    {
      _petService.Dispose();
      GC.SuppressFinalize(this);
    }

    public IEnumerable<PetVM> GetList()
    {
      return Mapper.Map<IEnumerable<Pet>, IEnumerable<PetVM>>(_petService.GetList());
    }

    public PetVM GetPetByID(Guid id)
    {
      return Mapper.Map<Pet, PetVM>(_petService.GetById(id));
    }

    public void Remove(Guid id)
    {
      _uow.BeginTransaction();
      _petService.Remove(id);
      _uow.Commit();
    }
  }
}
