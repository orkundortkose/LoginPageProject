using LoginPageProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginPageProject.Controllers
{
   

   
    
        public class HomeController : Controller
        {
           


            [HttpPost]
            public ActionResult Login(string username, string password)
            {
                if (username == "admin" && password == "123456")
                {
                    // Başarılı giriş durumunda yapılacak işlemler
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Başarısız giriş durumunda yapılacak işlemler
                    ViewBag.Error = "Geçersiz kullanıcı adı veya şifre.";
                    return View();
                }
            }
        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult FAQ()
        {

            return View();
        }



    }
    }
