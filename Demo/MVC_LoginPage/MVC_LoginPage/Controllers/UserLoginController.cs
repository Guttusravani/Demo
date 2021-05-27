using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_LoginPage.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace MVC_LoginPage.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select Email,Password from [dbo].[LoginDetails] where Email=@Email and Password=@Password";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Email", lc.UserName);
            sqlcomm.Parameters.AddWithValue("@Password", lc.Password);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.Read())
            {
                Session["username"] = lc.UserName.ToString();
                return RedirectToAction("welcome");

            }
            else
            {
                ViewData["Message"] = "User Login Details Failed !";
            }
            sqlconn.Close();
            return View();
        }
        public ActionResult welcome()
        {
            return View();
        }
    }
}