using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ISCAP.Models
{
    public class Slot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int slotId { get; set; }
        [Required]
        public string conference { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string authors { get; set; }

        public int? roomId { get; set; }
        
    }
}
