using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISCAP.Models
{
    public class SlotBlock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int slotBlockId { get; set; }
        [Required]
        public string title { get; set; }
        [ForeignKey("slotId")]
        [Display(Name ="Slots")]
        public int slotId { get; set; }
    }
}
