using Application;
using Domain;

namespace Infrastructure;

public class NoteRepository : INoteRepository
{
    public IEnumerable<Note> GetNotes() => new[]
    {
        new Note
        {
            Name = "test-note.js",
            Description = "A static test note",
            Language = "JavaScript"
        },
        new Note
        {
            Name = "another-snippet.cs",
            Description = "Another static test note",
            Language = "C#"
        },
    };
}
