using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VersionMVC5.Models;

namespace VersionMVC5.Controllers
{
    public class OficinasController : Controller
    {
        private ColegioEntities1 db = new ColegioEntities1();


        public string Ensayo()
        {
            Response.ContentType = "text/html";
            return "<html><head><title>HOLA MUNDO! Ensayo</title></head><body><a href='/Oficinas/Pruebas'>Hola</a></body></html>";
        }

        public string Pruebas()
        {
            Response.ContentType = "application/json";
            return "{'name':'valeria', 'last':'Moncada'}";
       
        }

        // GET: Oficinas
        public ActionResult Index()
        {
            return View(db.Oficina.ToList());
        }

        // GET: Oficinas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oficina oficina = db.Oficina.Find(id);
            if (oficina == null)
            {
                return HttpNotFound();
            }
            return View(oficina);
        }

        // GET: Oficinas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Oficinas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Oficina,Nom_Oficina,Tel_Oficina")] Oficina oficina)
        {
            if (ModelState.IsValid)
            {
                db.Oficina.Add(oficina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oficina);
        }

        // GET: Oficinas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oficina oficina = db.Oficina.Find(id);
            if (oficina == null)
            {
                return HttpNotFound();
            }
            return View(oficina);
        }

        // POST: Oficinas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Oficina,Nom_Oficina,Tel_Oficina")] Oficina oficina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oficina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oficina);
        }

        // GET: Oficinas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oficina oficina = db.Oficina.Find(id);
            if (oficina == null)
            {
                return HttpNotFound();
            }
            return View(oficina);
        }

        // POST: Oficinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Oficina oficina = db.Oficina.Find(id);
            db.Oficina.Remove(oficina);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
