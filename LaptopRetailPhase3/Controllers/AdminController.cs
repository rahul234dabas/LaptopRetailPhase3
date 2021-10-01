using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaptopRetailPhase3.Models;

namespace LaptopRetailPhase3.Controllers
{
    public class AdminController : Controller
    {
        string cs = string.Empty; string query = string.Empty;
        SqlConnection cn = null; SqlCommand cmd = null;

        public SqlConnection ConnectToSqlServer()
        {
            cs = this.cs = "server=H5CG1220K2K;integrated security=true;database=LaptopRetail";
            cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string uname,string password)
        {
            cn = ConnectToSqlServer();
            query = "select * from tbl_admin where uname = @uname and password=@password";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            TblAdmin ad = new TblAdmin();
            if (dr.Read())
            {
                cmd.Dispose(); dr.DisposeAsync();
                cn.Close();
                return RedirectToAction("Home");
            }
            else
            {
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "msg", "alert('Enter Valid Credentials')", true);
                cmd.Dispose(); dr.DisposeAsync();
                cn.Close();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
