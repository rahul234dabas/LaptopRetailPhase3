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
    public class UserSellerController : Controller
    {
        LaptopRetailContext context = new LaptopRetailContext();

        string cs = string.Empty; string query = string.Empty;
        SqlConnection cn = null; SqlCommand cmd = null;

        public SqlConnection ConnectToSqlServer()
        {
            cs = this.cs = "server=H5CG1220K2K;integrated security=true;database=LaptopRetail";
            cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
        // GET: UserSellerController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string fname,string password)
        {
            cn = ConnectToSqlServer();
            query = "select * from tbl_seller where fName = @fname and password=@password";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@password", password);
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

        // GET: UserSellerController/Details/5
        public ActionResult Details(int id)
        {
            return View(context.TblLaptops.Single(x => x.Sno == id));
        }

        // GET: UserSellerController/Create
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

        public ActionResult CreateLaptop()
        {
            return View();
        }

        // POST: SellerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateLaptop(TblLaptop l)
        {
            try
            {
                context.TblLaptops.Add(l);
                context.SaveChanges();
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserSellerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserSellerController/Edit/5
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

        // GET: UserSellerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserSellerController/Delete/5
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
