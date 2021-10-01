using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopRetailPhase3.Models;
namespace LaptopRetailPhase3.Controllers
{
    public class CustomersController : Controller
    {
        LaptopRetailContext context = new LaptopRetailContext();
        // GET: CustomersController
        public ActionResult Index()
        {
            return View(context.TblCustomers);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.TblCustomers.Single(x=>x.Sno==id));
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TblCustomer c)
        {
            try
            {
                context.TblCustomers.Add(c);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.TblCustomers.Single(x => x.Sno == id));
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TblCustomer c)
        {
            try
            {
                context.TblCustomers.Update(c);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.TblCustomers.Single(x => x.Sno == id));
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TblCustomer c)
        {
            try
            {
                context.TblCustomers.Remove(c);
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
