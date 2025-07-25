using Microsoft.Extensions.Logging;
using DreamSmart.Data;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Popups;
using Blazored.LocalStorage;
using DreamSmart.Shared;


namespace DreamSmart;

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

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSyncfusionBlazor();
        builder.Services.AddScoped<SfDialogService>(); /*Added by Amish as per requirement*/
        builder.Services.AddSyncfusionBlazor(); /*Added by Amish as per requirement*/
        builder.Services.AddSingleton<MyStateContainer>();/*Added by Amish as per requirement*/
        builder.Services.AddHttpClient();
        builder.Services.AddBlazoredLocalStorage();/*Added by Amish as per requirement*/
        return builder.Build();
	}
}
