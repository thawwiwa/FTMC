using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FTMC.Datas;
using FTMC.Models;
using FTMC.Services;

namespace FTMC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly FTMCdb _context;

        public CustomerController(FTMCdb context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }

        public async Task<IActionResult> CustomerDetail()
        {
            var detail = await _context.Customer.FirstOrDefaultAsync( w => w.CustomerID == 2 );
            return View(detail);
        }
    }
}