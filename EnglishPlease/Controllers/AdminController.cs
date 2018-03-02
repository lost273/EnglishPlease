using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnglishPlease.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EnglishPlease.Controllers
{
    public class AdminController : Controller {
        private UserManager<AppUser> userManager;
        public AdminController(UserManager<AppUser> usrMgr) {
            userManager = usrMgr;
        }
        public ViewResult Index() {
            return View(userManager.Users);
        }
    }
}