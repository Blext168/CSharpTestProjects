using _Microsoft.Android.Resource.Designer;
using Android.App;
using Android.Content;
using AndroidX.Core.App;

namespace DrinkSaverMAUI;

[BroadcastReceiver(Enabled = true, Exported = true)]
[IntentFilter(new[] { "com.example.MAIN_NOTIFICATION" })]
public class NotificationBroadcastReceiver : BroadcastReceiver
{
    public override void OnReceive(Context? context, Intent? intent)
    {
        var title = intent?.GetStringExtra("title") ?? "Reminder";
        var body = intent?.GetStringExtra("body") ?? "Drink your water!";
        var channelId = "maui_default_channel";
        
        var notificationManager = NotificationManagerCompat.From(context);
        
        // Channel erstellen (falls nötig)
        if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
        {
            var channel = new NotificationChannel(channelId, "Allgemeine Benachrichtigung", NotificationImportance.Default);
            notificationManager.CreateNotificationChannel(channel);
        }
        
        var builder = new NotificationCompat.Builder(context, channelId)
                      .SetContentTitle(title)
                      .SetContentText(body)
                      // mit eigenem Icon ersetzen
                      .SetSmallIcon(ResourceConstant.Drawable.notification_icon_background)
                      .SetAutoCancel(true);
        
        notificationManager.Notify(1000, builder.Build());
    }
}