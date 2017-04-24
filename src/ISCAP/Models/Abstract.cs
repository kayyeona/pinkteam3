using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISCAP.Models
{
    public class Abstract
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AbstractID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Affiliation { get; set; }

        [Required]
        public string SubjectArea { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Abstracts { get; set; }
    }
}
