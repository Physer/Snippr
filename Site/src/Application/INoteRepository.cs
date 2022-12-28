using Domain;

namespace Application;

public interface INoteRepository
{
    Task<IEnumerable<Note>> GetNotes();
}
