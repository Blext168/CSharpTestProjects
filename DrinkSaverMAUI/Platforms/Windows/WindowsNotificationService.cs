using DrinkSaverMAUI.Interfaces;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications;

namespace DrinkSaverMAUI;

public class WindowsNotificationService : INotificationService
{
    public async Task ScheduleRepeatingAsync(DateTime startAt, TimeSpan interval, string subject, string body, int notificationId)
    {
        if (startAt <= DateTime.Now) 
            startAt = DateTime.Now.AddSeconds(5); // defensiv
        
        try
        {
            var notifier = ToastNotificationManager.CreateToastNotifier();

            // Erstelle Toast-Inhalt (Toolkit hilft beim Erstellen)
            var toastContent = new ToastContentBuilder().AddText(subject)
                                                        .AddText(body)
                                                        .GetToastContent();

            // Beispiel: plane die nächsten 100 Ereignisse
            int occurrences = 100;
            var next = startAt.ToLocalTime();

            for (int i = 0; i < occurrences; i++)
            {
                var doc = new XmlDocument();
                doc.LoadXml(toastContent.GetContent());

                var scheduled = new ScheduledToastNotification(doc, new DateTimeOffset(next));
                scheduled.Id = $"notif-{notificationId}-{i}";
                notifier.AddToSchedule(scheduled);
                next = next.Add(interval);
            }
        }
        catch (Exception e)
        {
            await Application.Current.MainPage.DisplayAlert("Fehler", e.Message, "Okay");
        }
    }

    public async Task CancelAsync(int notificationId)
    {
        var notifier = ToastNotificationManager.CreateToastNotifier();
        var scheduled = notifier.GetScheduledToastNotifications();
        foreach (var s in scheduled)
            // optional Tag/Group Matching falls man Tags setzt 
            notifier.RemoveFromSchedule(s);
        
        await Task.CompletedTask;
    }
}