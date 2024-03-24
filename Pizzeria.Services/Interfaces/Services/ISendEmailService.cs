namespace Pizzeria.Services.Interfaces.Services;


public interface ISendEmailService
{
    public Task Send(string email, string body);
}
