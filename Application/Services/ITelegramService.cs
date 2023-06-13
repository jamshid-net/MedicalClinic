using Application.Models;

namespace Application.Services;

public interface ITelegramService
{
    public ValueTask SendMessage(TelegramMessageModel message);    
}
