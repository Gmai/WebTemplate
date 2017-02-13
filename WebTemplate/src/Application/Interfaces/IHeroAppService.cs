using Application.ViewModel;
using System;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IHeroAppService:IDisposable
    {
        HeroVM Add(HeroVM hero);
        IEnumerable<HeroVM> GetList();
    }
}
