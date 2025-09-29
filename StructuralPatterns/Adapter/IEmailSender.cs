namespace StructuralPatterns.Adapter;

public interface IEmailSender
{
    void Send(string pReceiver, string pSender, string pSubject, string pBody);
}