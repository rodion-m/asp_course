namespace Lesson2.Demo;

public class EmailSenderStub : IEmailSender
{
    private readonly Logger<EmailSenderStub> _logger;

    public EmailSenderStub(Logger<EmailSenderStub> logger)
    {
        _logger = logger;
    }
    
    public void Send(string message)
    {
        _logger.LogDebug("Отправка сообщения вызвана, но пропущена");
    }
}