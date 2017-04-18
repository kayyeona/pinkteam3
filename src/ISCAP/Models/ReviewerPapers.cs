using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISCAP.Models
{
    public class ReviewerPapers
    {
        public int ID { get; set; }

        public string PaperStatus { get; set; }

        public int TrackId { get; set; }

        public string PaperTitle { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime LastUpdate { get; set; }
    }
}
