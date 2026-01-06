namespace Di_Mvc_asp_net.Services;

public interface IGeneratorService<out T>
{
    T Generate();
}