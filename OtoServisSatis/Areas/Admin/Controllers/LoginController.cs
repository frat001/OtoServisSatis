﻿using Microsoft.AspNetCore.Mvc;

namespace OtoServisSatis.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}