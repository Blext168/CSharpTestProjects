namespace StructuralPatterns.Adapter;

public class EmailNotificationAdapter(IEmailSender pEmailSender) : INotificationAdapter
{
    public void Notify(User pUser, Message pMessage)
    {
        if (!pUser.AllowEmailNotifications)
            return;

        pEmailSender.Send(pUser.Email, pMessage.Sender, pMessage.Title, pMessage.Text);
    }
}