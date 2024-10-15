using TaskManagerAPI.Models;

namespace TaskManagerAPI.Service;

public class UserService
{
    private readonly List<User> _users =
    [
        new User { Username = "test", Password = "password", Role = "User" },
        new User { Username = "admin", Password = "admin123", Role = "Admin" }
    ];

    public User? Authenticate(string username, string password)
    {
        var user = _users.SingleOrDefault(u => u.Username == username && u.Password == password);
        return user ?? null;
    }
}
