using GYM.Application.Interfaces;
using GYM.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM.Presentation.AngularSite.Controllers
{
  public class HeroesController : Controller
  {
    private readonly IHeroAppService _heroAppService;

    public HeroesController(IHeroAppService heroAppService)
    {
      _heroAppService = heroAppService;
    }

    public JsonResult List()
    {
      var list = _heroAppService.GetList();
      return Json(list, JsonRequestBehavior.AllowGet);
    }

    // GET: Hero
    public ActionResult Index()
    {
      return View();
    }

    // GET: Hero/Details/5
    public ActionResult Details(Guid id)
    {
      var hero = _heroAppService.GetHeroByID(id);
      return View(hero);
    }

    // GET: Hero/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Hero/Create
    [HttpPost]
    public JsonResult Create(HeroVM hero)
    {
      try
      {
        hero = _heroAppService.Add(hero);
        return Json(new { success = true, hero = hero });
      }
      catch (Exception ex)
      {
        return Json(new { success = false, message = "Error" });
      }
    }

    // GET: Hero/Edit/5
    public ActionResult Edit(Guid id)
    {
      return View();
    }

    // POST: Hero/Edit/5
    [HttpPost]
    public ActionResult Edit(Guid id, FormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    // POST: Hero/Delete/5
    [HttpPost]
    public JsonResult Delete(Guid id)
    {
      try
      {
        _heroAppService.Remove(id);
        return Json(new { success = true });
      }
      catch (Exception ex)
      {
        return Json(new { success = false, message = "Error" });
      }
    }
  }
}
