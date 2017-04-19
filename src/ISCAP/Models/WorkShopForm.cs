using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISCAP.Models
{
    public class Workshop
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public string title { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string affiliation { get; set; }
        [Required]
        [EmailAddress]
        public string emailAddress { get; set; }
        [Required]
        [MaxLength(300)]
        public string overview { get; set; }
        [Required]
        [MaxLength(50)]
        public string targAud { get; set; }
        [Required]
        public string timeRequested { get; set; }
    }
}
