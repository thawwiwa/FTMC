using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FTMC.Controllers
{
    public class DevController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string DevList()
        {
            return "Dev List";
        }
    }
}