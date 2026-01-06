namespace Di_Mvc_asp_net.Pages;

using Di_Mvc_asp_net.Services;

using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    private readonly IGeneratorService<string> _generatorService;

    public string generatedData { get; private set; } = string.Empty;

    public LoginModel(IGeneratorService<string> generatorService) => _generatorService = generatorService;

    public void OnGet()
    {
        generatedData = _generateData();
    }

    private string _generateData() => _generatorService.Generate();
}