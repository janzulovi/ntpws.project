using System;

namespace ntpws.project.Service.Dto
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string NoteType { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
