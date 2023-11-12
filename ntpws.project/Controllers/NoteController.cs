using Microsoft.AspNetCore.Mvc;
using ntpws.project.Service;
using ntpws.project.Service.Dto;
using System.Collections.Generic;

namespace ntpws.project.Web.Controllers
{
    [ApiController]
    [Route("/note")]
    public class NoteController : Controller
    {
        private readonly NoteService _noteService;

        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }
        // GET: NoteController
        public ActionResult<List<NoteDto>> Get()
        {
            return _noteService.getAllNotes();
        }

        [HttpGet]
        [Route("/note/{id}")]
        public ActionResult<NoteDto> GetDetails(int id)
        {
            return _noteService.GetNote(id);
        }

        [HttpPost]
        [Route("/note/new")]
        public ActionResult<NoteDto> Post([FromBody] NoteDto note)
        {
            return _noteService.saveNewNote(note);
        }

        [HttpPut]
        [Route("/note/update")]
        public ActionResult<NoteDto> Put([FromBody] NoteDto note)
        {
            return _noteService.editNote(note);
        }
    }
}
