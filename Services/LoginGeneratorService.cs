namespace Di_Mvc_asp_net.Services;

public class LoginGeneratorService : IGeneratorService<string>
{
    public string Generate()
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();
        return new string(Enumerable.Repeat(chars, 8).Select(str => str[random.Next(str.Length)]).ToArray());
    }
}