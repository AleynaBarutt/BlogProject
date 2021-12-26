using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace web_proje.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }

      
    }
}
