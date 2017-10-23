using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NacSiteF.Models;

namespace NacSiteF.Controllers
{
    public class InvestidorController : Controller
    {
        private NacSiteEntities db = new NacSiteEntities();

        // GET: Investidor
        public ActionResult Index()
        {
            return View(db.INVESTIDOR.ToList());
        }

        // GET: Investidor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INVESTIDOR iNVESTIDOR = db.INVESTIDOR.Find(id);
            if (iNVESTIDOR == null)
            {
                return HttpNotFound();
            }
            return View(iNVESTIDOR);
        }

        // GET: Investidor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Investidor/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_INVESTIDOR,NOME,EMAIL,TELEFONE,ENDERECO,CIDADE,ESTADO")] INVESTIDOR iNVESTIDOR)
        {
            if (ModelState.IsValid)
            {
                db.INVESTIDOR.Add(iNVESTIDOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iNVESTIDOR);
        }

        // GET: Investidor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INVESTIDOR iNVESTIDOR = db.INVESTIDOR.Find(id);
            if (iNVESTIDOR == null)
            {
                return HttpNotFound();
            }
            return View(iNVESTIDOR);
        }

        // POST: Investidor/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_INVESTIDOR,NOME,EMAIL,TELEFONE,ENDERECO,CIDADE,ESTADO")] INVESTIDOR iNVESTIDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iNVESTIDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iNVESTIDOR);
        }

        // GET: Investidor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            INVESTIDOR iNVESTIDOR = db.INVESTIDOR.Find(id);
            if (iNVESTIDOR == null)
            {
                return HttpNotFound();
            }
            return View(iNVESTIDOR);
        }

        // POST: Investidor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            INVESTIDOR iNVESTIDOR = db.INVESTIDOR.Find(id);
            db.INVESTIDOR.Remove(iNVESTIDOR);
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
