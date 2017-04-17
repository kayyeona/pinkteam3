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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public DateTime EndTime { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Location { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Abstracts { get; set; }
    }
}
