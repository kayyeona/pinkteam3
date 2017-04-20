using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ISCAP.Models;

namespace ISCAP.Models
{
    public class Room
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int roomId { get; set; }
        [Required]
        public string roomName { get; set; }
        [Required]
        public string chair { get; set; }
        [Required]
        public int capacity { get; set; }   
        [ForeignKey("roomId")]
        public List<Slot> Slot { get; set; }
        [Required]
        public string paperType { get; set; }

    }
}
