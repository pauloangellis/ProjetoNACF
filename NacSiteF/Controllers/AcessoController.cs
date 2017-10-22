﻿using System;
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
    public class AcessoController : Controller
    {
        private NacSiteEntities db = new NacSiteEntities();

        // GET: Acesso
        public ActionResult Index()
        {
            return View(db.ACESSO.ToList());
        }

        // GET: Acesso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACESSO aCESSO = db.ACESSO.Find(id);
            if (aCESSO == null)
            {
                return HttpNotFound();
            }
            return View(aCESSO);
        }

        // GET: Acesso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acesso/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_LOGIN,EMAIL,SENHA,ATIVO,PERFIL,NOME")] ACESSO aCESSO)
        {
            if (ModelState.IsValid)
            {
                db.ACESSO.Add(aCESSO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aCESSO);
        }

        // GET: Acesso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACESSO aCESSO = db.ACESSO.Find(id);
            if (aCESSO == null)
            {
                return HttpNotFound();
            }
            return View(aCESSO);
        }

        // POST: Acesso/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_LOGIN,EMAIL,SENHA,ATIVO,PERFIL,NOME")] ACESSO aCESSO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCESSO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aCESSO);
        }

        // GET: Acesso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACESSO aCESSO = db.ACESSO.Find(id);
            if (aCESSO == null)
            {
                return HttpNotFound();
            }
            return View(aCESSO);
        }

        // POST: Acesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ACESSO aCESSO = db.ACESSO.Find(id);
            db.ACESSO.Remove(aCESSO);
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
