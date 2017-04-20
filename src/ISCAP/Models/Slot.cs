using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace ISCAP.Models
{
    public class Slot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int slotId { get; set; }
        [Required]
        [Display(Name ="Conference")]
        public string conference { get; set; }
        [Required]
        [Display(Name ="Title")]
        public string title { get; set; }
        [Required]
        [Display(Name ="Authors")]
        public string authors { get; set; }
        [Required]
        [Display(Name = "Slot Time")]
        public int slotTime { get; set; }
        public int? roomId { get; set; }

    }
}
