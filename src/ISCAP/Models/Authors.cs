using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISCAP.Models
{
    public partial class Authors
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public byte? AuthorOrder { get; set; }
        public bool? CAuthors { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool? JournalYes { get; set; }
        public bool? ConferenceYes { get; set; }
    }
}
