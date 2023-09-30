using FluentAssertions;

namespace PrimaryConstructorDoubleStorage;

public class UserTests
{
    [Test]
    public void ParameterValueIsOnlyStoredInTheProperty()
    {
        var user = new User("damir");
        user.Username = "damira";

        user.Username.Should().Be(user.ToString());
    }
}