namespace StructuralPatterns.Adapter;

public class EmailSender : IEmailSender
{
    public void Send(string pReceiver, string pSender, string pSubject, string pBody)
    {
        Console.WriteLine($"An:\t{pReceiver}" +
                          $"Von:\t{pSender}" +
                          $"Titel:\t{pSubject}" +
                          $"Text:\t{pBody}");
    }
}