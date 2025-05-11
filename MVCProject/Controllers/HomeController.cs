using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject.Models;
namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Registration()
        {
            //RegistrationDll regDll = new RegistrationDll();
            //BLRegistration.ConnectionDB(regDll);
            ViewBag.Message = "Your contact page.";
            return View();
        }

        [HttpPost]
        public ActionResult Registration(String name, String Email,String Phone,String DOB,String Aadhar,String Address,String Password)
        {
            RegistrationDll regDll = new RegistrationDll();
            regDll.Name = name;
            regDll.Email = Email;
            regDll.Phone = Phone;
            regDll.Dob = DOB;
            regDll.AAdhar = Aadhar;
            regDll.Address = Address;
            regDll.password = Password;
            BLRegistration.ConnectionDB(regDll);
            return View();
        }

        public ActionResult LoginFrom()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}