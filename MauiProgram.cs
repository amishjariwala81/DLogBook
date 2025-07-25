using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using Blazored.LocalStorage;
using DLogBook.Data;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;
using CommunityToolkit.Maui;
using DLogBook.Services;

namespace DLogBook;
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseBarcodeReader()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
                 

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Logging.AddDebug();

#endif
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<DatabaseContext>();
            builder.Services.AddScoped<SfDialogService>(); /*Added by Amish as per requirement*/
            builder.Services.AddSyncfusionBlazor(); /*Added by Amish as per requirement*/
            builder.Services.AddBlazoredLocalStorage();/*Added by Amish as per requirement*/
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton<EmailService>();

            return builder.Build();
        }
    }

