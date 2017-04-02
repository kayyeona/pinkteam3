using System;
using System.Collections.Generic;

namespace ISCAPLibrary.Entities
{
    public partial class Authors
    {
        public int ID { get; set; }
        public int SubmissionId { get; set; }
        public byte? AuthorOrder { get; set; }
        public bool? CAuthors { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? CollegeId { get; set; }
        public bool? JournalYes { get; set; }
        public bool? ConferenceYes { get; set; }
    }
}
