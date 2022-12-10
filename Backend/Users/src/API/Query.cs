using Domain;

namespace API;

public class Query
{
    public User GetUser() => new("mock_user_1337", "mock_user@snippr.com");
}
