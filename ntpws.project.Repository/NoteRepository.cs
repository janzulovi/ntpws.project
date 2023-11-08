using ntpws.project.Model;
using System.Collections.Generic;
using System.Linq;

namespace ntpws.project.Repository
{
    public class NoteRepository
    {
        private ProjectDbContext _context;

        public NoteRepository(ProjectDbContext context)
        {
            _context = context;
        }


        public List<Note> getAllNotes()
        {
            return _context.Notes.ToList();
        }

        public Note getNote(int id) 
        {
            return _context.Notes.FirstOrDefault(x => x.Id == id);
        }

        public Note saveNewNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();

            return _context.Notes.Where(n => n.Id == note.Id).FirstOrDefault();
        }
    }
}
