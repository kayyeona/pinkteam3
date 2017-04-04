using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ISCAP.Models.AccountViewModels
{
    public class ScheduledConferenceViewModel
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public string Description { get; set; }
        public string chair { get; set; }
    }
}
