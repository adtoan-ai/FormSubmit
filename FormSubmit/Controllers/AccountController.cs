using Microsoft.AspNetCore.Mvc;
using Ex4.Models; 

namespace Ex4.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
            {
                ViewBag.Message = "Login Success"; 
                ViewBag.Status = "success";       
            }
            else
            {
                ViewBag.Message = "Login Failed";  
                ViewBag.Status = "danger";        
            }
            return View(model);
        }
    }
}
