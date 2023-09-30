using FluentAssertions;

namespace PrimaryConstructorDoubleStorage;

public class UserTests
{
    [Test]
    public void PropertyAndParameterValueCanDiverge()
    {
        var user = new User("damir");
        user.Username = "damira";

        user.Username.Should().NotBe(user.ToString());
    }
}