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
  public class ItemService : IItemService
  {
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository ItemRepository) {
      _itemRepository = ItemRepository;
    }

    public Item Add(Item item)
    {
      return _itemRepository.Add(item);
    }

    public void Dispose()
    {
      _itemRepository.Dispose();
    }

    public Item GetById(Guid id)
    {
      return _itemRepository.GetById(id);
    }

    public IEnumerable<Item> GetList()
    {
      return _itemRepository.GetAll();
    }

    public void Remove(Guid id)
    {
      _itemRepository.Remove(id);
    }
  }
}
