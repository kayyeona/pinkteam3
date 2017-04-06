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
        public int sessionId { get; set; }
        public string conference { get; set; }
        public string title { get; set; }
        public string writers { get; set; }
        public int sessionDetailId { get; set; }
    }
}
