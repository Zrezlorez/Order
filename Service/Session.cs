using Order.Database;
using Order.Database.Model;

namespace Order.Service;

internal class Session
{
    public User User { get; }
    public Storage Storage { get; }
    public Role Role { get; }
    public static Session? Instance { get; set; }

    private Session(User user, Storage storage, Role role)
    {
        User = user;
        Storage = storage;
        Role = role;
    }

    public static int Auth(string login, string password)
    {
        using var db = new Context();

        var user = db.Users.SingleOrDefault(u =>
            u.Login.Equals(login) && u.Password.Equals(password));

        if (user == null) return 0;
        Instance = new Session(user, user.Storage, user.Role);
        return 1;
    }
}