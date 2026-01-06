namespace Di_Mvc_asp_net.Pages;

using Di_Mvc_asp_net.Services;

using Microsoft.AspNetCore.Mvc.RazorPages;

public class CoinModel : PageModel
{
    private readonly IGeneratorService<bool> _generatorService;

    public bool generatedData { get; private set; }

    public CoinModel(IGeneratorService<bool> generatorService) => _generatorService = generatorService;

    public void OnGet()
    {
        generatedData = _generateData();
    }

    private bool _generateData() => _generatorService.Generate();
}