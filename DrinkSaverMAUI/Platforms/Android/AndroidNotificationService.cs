using Android.App;
using Android.Content;
using Android.OS;
using DrinkSaverMAUI.Interfaces;
using Application = Android.App.Application;

namespace DrinkSaverMAUI;

public class AndroidNotificationService : INotificationService
{
    Context context => Application.Context;
    
    public async Task ScheduleRepeatingAsync(DateTime startAt, TimeSpan interval, string subject, string body, int notificationId)
    {
        var alarmManager = context.GetSystemService(Context.AlarmService) as AlarmManager;
        var intent = new Intent("com.example.MAIN_NOTIFICATION");
        intent.PutExtra("title", subject);
        intent.PutExtra("body", body);
        
        var pending = PendingIntent.GetBroadcast(context, notificationId, intent, PendingIntentFlags.UpdateCurrent | GetMutableFlag());
        
        var triggerMillis = (long)(startAt.ToUniversalTime() - DateTime.UnixEpoch).TotalMilliseconds;
        long intervalMillis = (long)interval.TotalMilliseconds;

        if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
        {
            // Wir verwenden setExactAndAllowWhileIdle periodisch: Android unterstützt kein perfekt wiederholendes exact; 
            // hier erst einmal SetInexactRepeating als praktikabler Kompromiss, oder reschedule nach Empfang.
            alarmManager.SetInexactRepeating(AlarmType.RtcWakeup, triggerMillis, intervalMillis, pending);
        }
        else
        {
            alarmManager.SetRepeating(AlarmType.RtcWakeup, triggerMillis, intervalMillis, pending);
        }

        await Task.CompletedTask;
    }

    public async Task CancelAsync(int notificationId)
    {
        var alarmManager = context.GetSystemService(Context.AlarmService) as AlarmManager;
        var intent = new Intent("com.example.MAIN_NOTIFICATION");
        var pending = PendingIntent.GetBroadcast(context, notificationId, intent, PendingIntentFlags.UpdateCurrent | GetMutableFlag());
        alarmManager?.Cancel(pending);
        pending.Cancel();
        await Task.CompletedTask;
    }
    
    private PendingIntentFlags GetMutableFlag()
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
            return PendingIntentFlags.Mutable;
        
        return 0;
    }
}