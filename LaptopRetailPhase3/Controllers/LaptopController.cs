using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopRetailPhase3.Models;

namespace LaptopRetailPhase3.Controllers
{
    public class LaptopController : Controller
    {
        LaptopRetailContext context = new LaptopRetailContext();
        // GET: LaptopController
        public ActionResult Index()
        {
            return View(context.TblLaptops);
        }

        // GET: LaptopController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.TblLaptops.Single(x=> x.Sno==id));
        }

        // GET: LaptopController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LaptopController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblLaptop l)
        {
            try
            {
                context.TblLaptops.Add(l);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LaptopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.TblLaptops.Single(x => x.Sno == id));
        }

        // POST: LaptopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TblLaptop l)
        {
            try
            {
                context.TblLaptops.Update(l);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LaptopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.TblLaptops.Single(x => x.Sno == id));
        }

        // POST: LaptopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TblLaptop l)
        {
            try
            {
                context.TblLaptops.Remove(l);
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
