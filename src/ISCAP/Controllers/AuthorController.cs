using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAPLibrary.Entities;
using ISCAP.Data;

namespace ISCAP.Controllers
{
    [Route("Author")]
    public class AuthorController : Controller
    {
        public ApplicationDbContext db;

        public AuthorController(ApplicationDbContext db)
        {
            this.db = db;
        }
        


        [HttpGet]
        [Route("Form")]
        public ViewResult AuthorForm()
        {
            return View();
        }

        [HttpPost]
        [Route("SaveForm")]
        public ContentResult SaveForm(Authors form)
        {
            db.Authors.Add(form);

            db.SaveChanges();
            return Content("WWWWWWWWorks");
        }
    }
}