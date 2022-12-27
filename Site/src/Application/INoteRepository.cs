using Domain;

namespace Application;

public interface INoteRepository
{
    IEnumerable<Note> GetNotes();
}
