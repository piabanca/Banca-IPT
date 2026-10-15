using Microsoft.Extensions.Logging;

namespace banca.mobileapp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

        // Naka-host na API: pareho ang gamit ng laptop (Windows) at phone (Android)
        string baseUrl = "https://rochemagsayo-001-site19.jtempurl.com/";

        builder.Services.AddScoped(sp =>
        {
            return new HttpClient { BaseAddress = new Uri(baseUrl) };
        });

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}