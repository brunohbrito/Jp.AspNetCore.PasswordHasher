using Bogus;

namespace NetDevPack.Security.PasswordHasher.Tests.Fakers;

public class GenericUserFaker
{
    public static Faker<GenericUser> GenerateUser()
    {
        return new Faker<GenericUser>();
    }
}