namespace Di_Mvc_asp_net.Services;

public class NumberGeneratorService : IGeneratorService<int>
{
    public int Generate()
    {
        Random random = new Random();
        return random.Next(0, 101);
    }
}