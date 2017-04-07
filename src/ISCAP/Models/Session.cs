using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ISCAP.Models
{
    public class Session
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int sessionId { get; set; }
        [Required]
        public string conference { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string writers { get; set; }
        [Required]
        public int sessionDetailId { get; set; }
        [Required]
        public string paperType { get; set; }
    }
}
