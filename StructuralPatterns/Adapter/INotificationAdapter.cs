namespace StructuralPatterns.Adapter;

public interface INotificationAdapter
{
    void Notify(User pUser, Message pMessage);
}