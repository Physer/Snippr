namespace Domain;

public class Note
{
    public string Name { get; set; }
    public string Description { get; set; }

    public string? Language { get; set; }

    public Note(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public Note(string name, string description, string language) : this(name, description) => Language = language;
}
