using GYM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Domain.Interfaces.Service
{
  public interface IPetService:IDisposable {
    Pet Add(Pet pet);
    IEnumerable<Pet> GetList();
    Pet GetById(Guid id);
    void Remove(Guid id);
  }
}
