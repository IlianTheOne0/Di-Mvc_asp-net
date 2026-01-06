using Di_Mvc_asp_net.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddTransient<IGeneratorService<int>, NumberGeneratorService>();
builder.Services.AddTransient<IGeneratorService<string>, LoginGeneratorService>();
builder.Services.AddTransient<IGeneratorService<bool>, CoinGeneratorService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
