﻿namespace Pizzeria.Interfaces.Services;

public interface ISendSMSService
{
    public Task SendSms(string phoneNumber, string text);
}
