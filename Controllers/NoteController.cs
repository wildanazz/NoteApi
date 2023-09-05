using Microsoft.AspNetCore.Mvc;
using NoteApi.Services;
using NoteApi.Models;

namespace NoteApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NoteController : ControllerBase
{
    private readonly NoteService _noteService;

    public NoteController(NoteService noteService)
    {
        _noteService = noteService;
    }

    [HttpGet]
    public async Task<List<Note>> Get() => await _noteService.GetAsync();
}