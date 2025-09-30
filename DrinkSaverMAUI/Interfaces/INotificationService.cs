namespace DrinkSaverMAUI.Interfaces;

public interface INotificationService
{

    /// <summary>
    /// Plant wiederholte lokale Benachrichtigungen.
    /// </summary>
    /// <param name="startAt">Erster Zeitpunkt (lokal)</param>
    /// <param name="interval">Intervall (z.B. TimeSpan.FromMinutes(15))</param>
    /// <param name="subject">Titel</param>
    /// <param name="body">Text</param>
    /// <param name="notificationId">Id für das Canceln</param>
    /// <returns></returns>
    Task ScheduleRepeatingAsync(DateTime startAt, TimeSpan interval, string subject, string body, int notificationId);

    /// <summary>
    /// Stoppt/Cancelt geplante Benachrichtigungen mit der Id.
    /// </summary>
    /// <param name="notificationId">Id für das Canceln</param>
    /// <returns></returns>
    Task CancelAsync(int notificationId);
}