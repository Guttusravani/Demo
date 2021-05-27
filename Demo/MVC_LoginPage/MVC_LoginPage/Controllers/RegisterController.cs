using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_LoginPage.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MVC_LoginPage.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(RegisterClass rc, HttpPostedFileBase file)
        {
            if (!CheckUserExist(rc.Username))
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[LoginDetails] (Username,Email,Password,Gender,Question1,Question2) values (@Username,@Email,@Password,@Gender,@Question1,@Question2)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlconn.Open();
                sqlcomm.Parameters.AddWithValue("@Username", rc.Username);
                sqlcomm.Parameters.AddWithValue("@Email", rc.Email);
                sqlcomm.Parameters.AddWithValue("@Password", rc.Password);
                sqlcomm.Parameters.AddWithValue("@Gender", rc.Gender);
                sqlcomm.Parameters.AddWithValue("@Question1", rc.Question1);
                sqlcomm.Parameters.AddWithValue("@Question2", rc.Question2);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                ViewData["Message"] = " User Record " + rc.Username + " Is Saved Successfully !";
                Session["username"] = rc.Username.ToString();
                return RedirectToAction("welcome");
                
            }
            else
            {
                ViewData["Message"] = " User Name: " + rc.Username + " already exists Please try with different name!";
                return View();
            }

        }
        private bool CheckUserExist(string userName)
        {
            bool isUserExist = false;
            string mainconn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select Username from [dbo].[LoginDetails] where Username=@Username";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Username", userName);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.FieldCount > 0)
            {
                isUserExist = true;
            }

            sqlconn.Close();
            return isUserExist;
        }

        [Route("Register")]
        public ActionResult welcome()
        {
            return View();
        }
    }
}