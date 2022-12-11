namespace Domain;

public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }
}
