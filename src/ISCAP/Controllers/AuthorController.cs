using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAPLibrary.Entities;

namespace ISCAP.Controllers
{
    [Route("Author")]
    public class AuthorController : Controller
    {
        [HttpGet]
        [Route("Form")]
        public ViewResult AuthorForm()
        {
            return View();
        }

        [HttpPost]
        [Route("SaveForm")]
        public ViewResult SaveForm(Authors form)
        {
            return View();
        }
    }
}