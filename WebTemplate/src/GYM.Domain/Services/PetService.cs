using GYM.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYM.Domain.Entities;
using GYM.Domain.Interfaces.Repository;

namespace GYM.Domain.Services
{
  public class PetService : IPetService
  {
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository) {
      _petRepository = petRepository;
    }

    public Pet Add(Pet pet)
    {
      return _petRepository.Add(pet);
    }

    public void Dispose()
    {
      _petRepository.Dispose();
    }

    public Pet GetById(Guid id)
    {
      return _petRepository.GetById(id);
    }

    public IEnumerable<Pet> GetList()
    {
      return _petRepository.GetAll();
    }

    public void Remove(Guid id)
    {
      _petRepository.Remove(id);
    }
  }
}
