using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ISCAP.Models;
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
        public ViewResult Form()
        {
            return View();
        }

        [HttpPost]
        [Route("SaveForm")]
        public ContentResult SaveForm(Author form)
        {
            db.Authors.Add(form);

            db.SaveChanges();
            return Content("all data saved");
        }
    }
}