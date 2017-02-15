using Application;
using Application.Interfaces;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GYM.MvcSite.Controllers
{
  [RoutePrefix("Admin-Heroes")]
  public class HeroController : Controller
  {

    private readonly IHeroAppService _heroAppService;


    public HeroController(IHeroAppService heroAppService)
    {
      _heroAppService = heroAppService;
    }

    // GET: Hero
    [Route("List")]
    public ActionResult Index()
    {
      return View(_heroAppService.GetList());
    }

    // GET: Hero/Details/5
    [Route("Details/{id:guid}")]
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

        _heroAppService.Remove(id.Value);
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
