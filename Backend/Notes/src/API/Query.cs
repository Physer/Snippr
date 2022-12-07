using Domain;

namespace API;

public class Query
{
    public Note GetNote() => new("Mocked note", "This is a static note description");
}
