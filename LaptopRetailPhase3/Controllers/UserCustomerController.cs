using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopRetailPhase3.Models;
using Microsoft.Data.SqlClient;

namespace LaptopRetailPhase3.Controllers
{
    public class UserCustomerController : Controller
    {
        LaptopRetailContext context = new LaptopRetailContext();

        static List<TblLaptop> purchasedLaptops = new List<TblLaptop>();

        string cs = string.Empty; string query = string.Empty;
        SqlConnection cn = null; SqlCommand cmd = null;

        public SqlConnection ConnectToSqlServer()
        {
            cs = this.cs = "server=H5CG1220K2K;integrated security=true;database=LaptopRetail";
            cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
        // GET: UserCustomerController
        public ActionResult Index()
        {
            purchasedLaptops.Clear();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string cemail, string pno)
        {
            cn = ConnectToSqlServer();
            query = "select * from tbl_customers where cemail = @cemail and pno=@pno";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@cemail", cemail);
            cmd.Parameters.AddWithValue("@pno", pno);
            SqlDataReader dr = cmd.ExecuteReader();
            TblAdmin ad = new TblAdmin();
            if (dr.Read())
            {
                cmd.Dispose(); dr.DisposeAsync();
                cn.Close();
                return RedirectToAction("List");
            }
            else
            {
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "msg", "alert('Enter Valid Credentials')", true);
                cmd.Dispose(); dr.DisposeAsync();
                cn.Close();
                return RedirectToAction("Index");
            }
        }

        public ActionResult List()
        {
            return View(context.TblLaptops);
        }

        public ActionResult PurchaseLaptop()
        {
            return View(context.TblLaptops);
        }

        public ActionResult Purchased(int id)
        {
            TblLaptop t = context.TblLaptops.Single(x => x.Sno == id);
            int index = t.Sno;
            purchasedLaptops.Add(t);
            ViewBag.list = purchasedLaptops;
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }

        // GET: UserCustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.TblLaptops.Single(x => x.Sno == id));
        }

        // GET: UserCustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserCustomerController/Create
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

        // GET: UserCustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserCustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserCustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserCustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
