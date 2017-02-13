using Application.Interfaces;
using System;
using Application.ViewModel;
using GYM.Infra.Data.Repository;
using GYM.Domain.Entities;
using AutoMapper;
using System.Collections.Generic;

namespace Application
{
    public class HeroAppService : IHeroAppService 
    {
        private readonly HeroRepository rp;

        public HeroAppService() {
            rp = new HeroRepository();
        }

        public HeroVM Add(HeroVM heroVm)
        {
            var hero = Mapper.Map<HeroVM, Hero>(heroVm);
            rp.Add(hero);
            return heroVm;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HeroVM> GetList()
        {
            return Mapper.Map<IEnumerable<Hero>,IEnumerable<HeroVM>>(rp.GetAll());
        }
    }
}
