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
    public class DocentesController : Controller
    {
        private ColegioEntities1 db = new ColegioEntities1();

        // GET: Docentes
        public ActionResult Index()
        {
            return View(db.Docente.ToList());
        }

        // GET: Docentes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docente.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        // GET: Docentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Docentes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Docente,Nom_Docente,Dire_Docente,Tel_Docente")] Docente docente)
        {
            if (ModelState.IsValid)
            {
                db.Docente.Add(docente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(docente);
        }

        // GET: Docentes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docente.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        // POST: Docentes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Docente,Nom_Docente,Dire_Docente,Tel_Docente")] Docente docente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(docente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(docente);
        }

        // GET: Docentes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docente docente = db.Docente.Find(id);
            if (docente == null)
            {
                return HttpNotFound();
            }
            return View(docente);
        }

        // POST: Docentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Docente docente = db.Docente.Find(id);
            db.Docente.Remove(docente);
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
