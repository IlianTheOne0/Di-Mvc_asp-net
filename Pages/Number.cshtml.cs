namespace Di_Mvc_asp_net.Pages;

using Di_Mvc_asp_net.Services;

using Microsoft.AspNetCore.Mvc.RazorPages;

public class NumberModel : PageModel
{
    private readonly IGeneratorService<int> _generatorService;

    public int generatedData { get; private set; }

    public NumberModel(IGeneratorService<int> generatorService) => _generatorService = generatorService;

    public void OnGet()
    {
        generatedData = _generateData();
    }

    private int _generateData() => _generatorService.Generate();
}