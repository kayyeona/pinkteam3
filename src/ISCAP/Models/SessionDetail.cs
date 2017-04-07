using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ISCAP.Models;

namespace ISCAP.Models
{
    public class SessionDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int sessionDetailId { get; set; }    
        [Required]    
        public string location { get; set; }
        [Required]
        public string chair { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public int number { get; set; }
        [Required]
        [ForeignKey("sessionDetailId")]
        public List<Session> Session { get; set; }

    }
}
