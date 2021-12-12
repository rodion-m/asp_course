namespace Lesson2.Demo.WithHighCoupledDI;

public class RegistrationService
{
    private readonly ASESEmailSender _emailSender;
    
    public RegistrationService(ASESEmailSender emailSender)
    {
        _emailSender = emailSender;
    }
    
    public void Register()
    {
        // ...
        _emailSender.Send("Вы успешно зарегистрированы");
    }
}