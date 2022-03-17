using Ajax_Test.Data;
using Ajax_Test.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Country"] = new SelectList(_context.TblCountries,"Id","CountryName");
            

            return View();
        }
        public JsonResult getStates(int id)
        {
            var obj = _context.TblState.Where(item => item.CountryId == id);
            var jsonString = Json(obj);
                return jsonString;
        }

        public JsonResult getCity(int id)
        {
            var obj = _context.TblCity.Where(item => item.StateId== id);
            var jsonString = Json(obj);
            return jsonString;
        }
    }
}
