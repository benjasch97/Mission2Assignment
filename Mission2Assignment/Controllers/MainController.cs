using Microsoft.AspNetCore.Mvc;
using Mission2Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2Assignment.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index() // This returns the view page for the index page
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult GradeCalc() // this returns the view for the GradeCalc page
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalc(GradeCalcModel model) // this sends the information received from the GradeCalc form to the GradeCalcModel
        {
            return View();
        }
    }
}
