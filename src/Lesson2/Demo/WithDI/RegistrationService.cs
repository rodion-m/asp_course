namespace Lesson2.Demo.WithDI;

public class RegistrationService
{
    private readonly IEmailSender _emailSender;
    private readonly Random _random;


    public RegistrationService(IEmailSender emailSender, Random random)
    {
        _emailSender = emailSender;
        _random = random;
    }

    public Task RegisterUser()
    {
        throw new NotImplementedException();
    }
}
