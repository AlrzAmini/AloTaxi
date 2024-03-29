﻿using AloTaxi.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AloTaxi.Web.Areas.AdminPanel.Controllers.AdminBase;

namespace AloTaxi.Web.Areas.AdminPanel.Controllers
{
    [Route("admin")]
    public class AdminHomeController : AdminBaseController
    {
        private readonly ILogger<AdminHomeController> _logger;

        public AdminHomeController(ILogger<AdminHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}