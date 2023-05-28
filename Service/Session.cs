using Order.Database;
using Order.Database.Model;

namespace Order.Service;

internal class Session
{
    public User User { get; }
    public static Session? Instance { get; set; }

    private Session(User user)
    {
        User = user;
    }

    public static int Auth(string login, string password)
    {
        using var db = new Manager();

        var user = db.Users.SingleOrDefault(u =>
            u.Login.Equals(login) && u.Password.Equals(password));

        if (user == null) return 0;

        Instance = new Session(user);
        return 1;
    }
}