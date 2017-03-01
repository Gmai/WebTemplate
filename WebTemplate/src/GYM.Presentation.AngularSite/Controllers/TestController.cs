using GYM.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYM.Presentation.AngularSite.Controllers
{
  public class TestController : Controller
  {
    private readonly IHeroAppService _heroAppService;

    public TestController(IHeroAppService heroAppService)
    {
      _heroAppService = heroAppService;
    }

    // GET: Test
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Rote1()
    {
      return View();
    }

    public ActionResult Rote2(int donuts = 1)
    {
      ViewBag.Donuts = donuts;
      return View();
    }

    [Authorize]
    public ActionResult Rote3()
    {
      return View();
    }

    public JsonResult HeroesList() {
      var list = _heroAppService.GetList();
      return Json(list, JsonRequestBehavior.AllowGet);
    }
  }
}