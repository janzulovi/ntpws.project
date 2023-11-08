using System;
using System.ComponentModel.DataAnnotations;

namespace ntpws.project.Model
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public NoteType NoteType { get; set; }
    }
}
