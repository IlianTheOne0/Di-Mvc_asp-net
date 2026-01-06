namespace Di_Mvc_asp_net.Services;

public class CoinGeneratorService : IGeneratorService<bool>
{
    public bool Generate()
    {
        Random random = new Random();
        return random.Next(0, 2) == 0;
    }
}