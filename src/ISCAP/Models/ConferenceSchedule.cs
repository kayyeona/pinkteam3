using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ISCAP.Models
{
    public class ConferenceSchedule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Day { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime MeetingTime { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
