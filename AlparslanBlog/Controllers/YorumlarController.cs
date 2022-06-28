using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
public class YorumlarController : Controller
{
    YorumlarManager ym = new YorumlarManager(new EFYorumlarRepository());
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public PartialViewResult PartialYorumEkle()
    {
        return PartialView();
    }
    [HttpPost]
    public PartialViewResult PartialYorumEkle(Yorumlar p)
    {
        p.YorumTarihi = System.DateTime.Now;
        p.YorumDurumu = true;
        p.BlogID = 1;
        ym.YorumEkle(p);
        return PartialView();
    }
    public PartialViewResult PartialYorumListele(int id)
    {
        var deger = ym.HepsiniGetir(id);
        return PartialView(deger);
    }
}

