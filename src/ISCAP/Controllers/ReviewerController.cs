using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ISCAP.Controllers
{
    public class ReviewerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Default()
        {
            return View();
        }
    }
}