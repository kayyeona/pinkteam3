using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ISCAP.Models
{
    public class AuthorsForms
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
