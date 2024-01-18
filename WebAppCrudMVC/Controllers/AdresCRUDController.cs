using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppCrudMVC.Models;

namespace WebAppCrudMVC.Controllers
{
    public class AdresCRUDController : Controller
    {
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            return View(context.Adresler.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Adres adres)
        {
            if (ModelState.IsValid)
            {
                context.Adresler.Add(adres);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }

            }
            return View(adres);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adres adres = context.Adresler.Find(id);
            if (adres == null)
                return HttpNotFound();
            return View(adres);
        }
        [HttpPost]
        public ActionResult Edit(Adres adres)
        {
            if (ModelState.IsValid)
            {
                context.Entry(adres).State = System.Data.Entity.EntityState.Modified;
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(adres);

        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adres adres = context.Adresler.Find(id);
            if (adres == null)
                return HttpNotFound();
            return View(adres);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Adres adres = context.Adresler.Find(id);
            context.Adresler.Remove(adres);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}