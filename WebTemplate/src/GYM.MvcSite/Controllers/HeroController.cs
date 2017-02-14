using Application;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GYM.MvcSite.Controllers
{
  public class HeroController : Controller
  {

    private readonly HeroAppService _heroAppService;


    public HeroController()
    {
      _heroAppService = new HeroAppService();
    }

    // GET: Hero
    public ActionResult Index()
    {
      return View(_heroAppService.GetList());
    }

    // GET: Hero/Details/5
    public ActionResult Details(Guid? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      var hero = _heroAppService.GetHeroByID(id.Value);
      if (hero == null)
      {
        return HttpNotFound();
      }

      return View(hero);
    }

    // GET: Hero/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Hero/Create
    [HttpPost]
    public ActionResult Create(FormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    // GET: Hero/Edit/5
    public ActionResult Edit(Guid? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      var hero = _heroAppService.GetHeroByID(id.Value);
      if (hero == null)
      {
        return HttpNotFound();
      }

      return View(hero);
    }

    // POST: Hero/Edit/5
    [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
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

    // GET: Hero/Delete/5
    public ActionResult Delete(Guid? id)
    {
      if (id == null) {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      var hero = _heroAppService.GetHeroByID(id.Value);
      if (hero == null) {
        return HttpNotFound();
      }

      return View(hero);
    }

    // POST: Hero/SaveDelete/5
    [HttpPost]
    public ActionResult SaveDelete(Guid? id)
    {
      try
      {
        if (id == null)
        {
          return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        _heroAppService.Delete(id.Value);
        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        _heroAppService.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
