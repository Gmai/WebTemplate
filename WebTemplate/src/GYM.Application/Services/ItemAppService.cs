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
  public class ItemAppService : IItemAppService
  {
    private readonly IItemService _itemService;
    private readonly IUnitOfWork _uow;

    public ItemAppService(IItemService itemService, IUnitOfWork uow) {
      _itemService = itemService; 
      _uow = uow;
    }

    public ItemVM Add(ItemVM itemVm)
    {
      var item = Mapper.Map<ItemVM, Item>(itemVm);
      ObjectUtils.CheckNullObj(item);

      _uow.BeginTransaction();
      _itemService.Add(item);

      _uow.Commit();

      return itemVm;
    }

    public void Dispose()
    {
      _itemService.Dispose();
      GC.SuppressFinalize(this);
    }

    public IEnumerable<ItemVM> GetList()
    {
      return Mapper.Map<IEnumerable<Item>, IEnumerable<ItemVM>>(_itemService.GetList());
    }

    public ItemVM GetItemByID(Guid id)
    {
      return Mapper.Map<Item, ItemVM>(_itemService.GetById(id));
    }

    public void Remove(Guid id)
    {
      _uow.BeginTransaction();
      _itemService.Remove(id);
      _uow.Commit();
    }
  }
}
