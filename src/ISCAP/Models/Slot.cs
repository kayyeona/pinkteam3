using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ISCAP.Models;

namespace ISCAP.Models
{
    public class Slot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int slotId { get; set; }    
        [Required]
        public string chair { get; set; }        
        [ForeignKey("slotId")]
        public List<Session> Session { get; set; }
        [Required]
        public string paperType { get; set; }

    }
}
