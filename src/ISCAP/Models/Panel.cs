using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISCAP.Models
{
    public class Panel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int panelId { get; set; }
        [Required]
        public string panelTitle { get; set; }
        [Required]
        public string modName { get; set; }
        [Required]
        public string modAffil { get; set; }
        [Required]
        [EmailAddress]
        public string modEmail { get; set; }
        [Required]
        public string panelistName { get; set; }
        [Required]
        public string panelistAffil { get; set; }
        [Required]
        [EmailAddress]
        public string panelistEmail { get; set; }
        [Required]
        [MaxLength(5000)]
        public string panelOV { get; set; }
        [Required]
        [MaxLength(2000)]
        public string targAud { get; set; }
        [Required]
        public int timeReq { get; set; }
    }
}
