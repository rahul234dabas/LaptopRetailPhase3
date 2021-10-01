using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopRetailPhase3.Models;
namespace LaptopRetailPhase3.Controllers
{
    public class SellerController : Controller
    {
        LaptopRetailContext context = new LaptopRetailContext();

        // GET: SellerController
        public ActionResult Index()
        {
            return View(context.TblSellers);
        }

        // GET: SellerController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.TblSellers.Single(x=>x.Sno==id));
        }

        // GET: SellerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SellerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblSeller s)
        {
            try
            {
                context.TblSellers.Add(s);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SellerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.TblSellers.Single(x => x.Sno == id));
        }

        // POST: SellerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TblSeller s)
        {
            try
            {
                context.TblSellers.Update(s);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SellerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.TblSellers.Single(x => x.Sno == id));
        }

        // POST: SellerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TblSeller s)
        {
            try
            {
                context.TblSellers.Remove(s);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
