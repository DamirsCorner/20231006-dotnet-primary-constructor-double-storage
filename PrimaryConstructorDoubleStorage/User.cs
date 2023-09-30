namespace PrimaryConstructorDoubleStorage;
public class User(string username)
{
    public string Username { get; set; } = username;

    public override string ToString()
    {
        return Username;
    }
}
