using ntpws.project.Model;
using ntpws.project.Repository;
using ntpws.project.Service.Dto;
using System.Collections.Generic;

namespace ntpws.project.Service
{
    public class NoteService
    {
        private readonly NoteRepository _noteRepository;

        public NoteService(NoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public List<NoteDto> getAllNotes()
        {
            var notes = _noteRepository.getAllNotes();

            var notesDto = new List<NoteDto>();

            foreach (var note in notes)
            {
                notesDto.Add(this.mapNoteToNoteDto(note));
            }

            return notesDto;
        }


        public NoteDto GetNote(int id)
        {
            var note = _noteRepository.getNote(id);

            return mapNoteToNoteDto(note);
        }


        public NoteDto saveNewNote(NoteDto noteDto)
        {
            var note = mapNoteDtoToNote(noteDto);

            var savedNote = _noteRepository.saveNewNote(note);

            return mapNoteToNoteDto(savedNote);
        }

        public NoteDto editNote(NoteDto noteDto)
        {
            var note = mapNoteDtoToNote(noteDto);

            var savedNote = _noteRepository.updateNote(note);

            return mapNoteToNoteDto(savedNote);
        }

        public void deleteNote(int id) {
            var noteToDelete = _noteRepository.getNote(id);
            _noteRepository.deleteNote(noteToDelete);
        }


        private NoteDto mapNoteToNoteDto(Note note)
        {
            return new NoteDto()
            {
                Id = note.Id,
                Title = note.Title,
                Description = note.Description,
                CreatedBy = note.CreatedBy,
                CreatedOn = note.CreatedOn,
                DueDate = note.DueDate,
                NoteType = note.NoteType,
                Status = note.Status
            };
        }

        private Note mapNoteDtoToNote(NoteDto noteDto)
        {
            var note = new Note()
            {
                Id = noteDto.Id,
                Title = noteDto.Title,
                Description = noteDto.Description,
                CreatedBy = noteDto.CreatedBy,
                CreatedOn = noteDto.CreatedOn,
                DueDate = noteDto.DueDate,
                NoteType = noteDto.NoteType,
                Status = noteDto.Status
            };

            return note;
        }
    }
}
