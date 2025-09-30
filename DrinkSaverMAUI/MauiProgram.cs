using System.Diagnostics;
using Microsoft.Extensions.Logging;
using DrinkSaverMAUI.Interfaces;
using Microsoft.Toolkit.Uwp.Notifications;

namespace DrinkSaverMAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
               });

#if ANDROID
        builder.Services.AddSingleton<INotificationService, AndroidNotificationService>();
#elif WINDOWS
        builder.Services.AddSingleton<INotificationService, WindowsNotificationService>();

        // try
        // {
        //     DesktopNotificationManagerCompat.RegisterAumidAndComServer<WindowsNotificationService>("com.schiefer.drinksaver");
        //     DesktopNotificationManagerCompat.RegisterActivator<WindowsNotificationService>();
        // }
        // catch (Exception ex)
        // {
        //     Debug.WriteLine($"Register toast helper failed: {ex}");
        // }
        
#endif
        
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}