using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppCrudMVC.Models;

namespace WebAppCrudMVC.Controllers
{
    public class KullaniciCRUDController : Controller
    {
        DatabaseContext context = new DatabaseContext();
        // GET: KullaniciCRUD
        public ActionResult Index()
        {
            return View(context.Kullanicilar.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                context.Kullanicilar.Add(kullanici);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(kullanici);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = context.Kullanicilar.Find(id);
            if (kullanici == null)
                return HttpNotFound();
            return View(kullanici);
        }
        [HttpPost]
        public ActionResult Edit(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                context.Entry(kullanici).State = System.Data.Entity.EntityState.Modified;
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(kullanici);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = context.Kullanicilar.Find(id);
            if (kullanici == null)
                return HttpNotFound();
            return View(kullanici);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Kullanici kullanici = context.Kullanicilar.Find(id);
            context.Kullanicilar.Remove(kullanici);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}