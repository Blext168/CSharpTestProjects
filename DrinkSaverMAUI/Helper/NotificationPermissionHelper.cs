using Microsoft.Maui.ApplicationModel; // namespace
namespace DrinkSaverMAUI.Helper;

public static class NotificationPermissionHelper
{
    public static async Task<bool> RequestNotificationPermissionAsync()
    {
        // 1) Status prüfen
        var status = await Permissions.CheckStatusAsync<Permissions.PostNotifications>();
        
        // 2) Wenn rationale nötig ist, erklärende UI zeigen
        if (status == PermissionStatus.Denied && Permissions.ShouldShowRationale<Permissions.PostNotifications>())
        {
            // Zeige ein kurzes UI (Popup/Modal) warum du Notifications brauchst
            await Application.Current.MainPage.DisplayAlert(
                "Benachrichtigungen",
                "Um dich an das Wasser trinken zu erinnern.",
                "Okay");
        }
        
        // 3) Wenn noch nicht erlaubt -> Anfragen
        if (status == PermissionStatus.Denied)
        {
            var result = await Application.Current.MainPage.DisplayAlert( 
                             title: "Benachrichtigungen deaktiviert",
                             message: "Benachrichtigungen sind deaktiviert. Möchtest du die App-Einstellungen öffnen, um die " +
                                      "Berechtigung manuell zu setzen?",
                             accept: "Einstellungen öffnen", 
                             cancel: "Später");
            
            if (result)
                // Öffnet die Systemseite für die App-Einstellungen (plattformunabhängig implementiert)
                AppInfo.Current.ShowSettingsUI();

            return false;
        }
        
        return status == PermissionStatus.Granted;
    }
}