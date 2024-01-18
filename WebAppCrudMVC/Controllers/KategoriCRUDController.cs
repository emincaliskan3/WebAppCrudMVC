using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppCrudMVC.Models;

namespace WebAppCrudMVC.Controllers
{
    public class KategoriCRUDController : Controller
    {
        // GET: KategoriCRUD
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            return View(context.Kategoriler.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                context.Kategoriler.Add(kategori);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(kategori);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kategori kategori = context.Kategoriler.Find(id);
            if (kategori == null)
                return HttpNotFound();
            return View(kategori);
        }
        [HttpPost]
        public ActionResult Edit(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                context.Entry(kategori).State = System.Data.Entity.EntityState.Modified;
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(kategori);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kategori kategori = context.Kategoriler.Find(id);
            if (kategori == null)
                return HttpNotFound();
            return View(kategori);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Kategori kategori = context.Kategoriler.Find(id);
            context.Kategoriler.Remove(kategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}