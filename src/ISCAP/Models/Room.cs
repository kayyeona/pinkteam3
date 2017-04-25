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
        [Display(Name = " Room Name")]
        public string roomName { get; set; }
        [Display(Name = " Event Chair")]
        [Required]
        public string chair { get; set; }
        [Required]
        [Display(Name = " Room Capacity")]
        public int capacity { get; set; }   
        [ForeignKey("roomId")]
        public List<Slot> Slot { get; set; }
        [Required]
        public string paperType { get; set; }

    }
}
