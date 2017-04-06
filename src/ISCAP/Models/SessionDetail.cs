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
        public int sessionDetailId { get; set; }        
        public string location { get; set; }
        public string chair { get; set; }
        public DateTime date { get; set; }
        public int number { get; set; }
        [ForeignKey("sessionDetailId")]
        public List<Session> Session { get; set; }

    }
}
