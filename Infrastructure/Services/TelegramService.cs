using Application.Models;
using Application.Services;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Infrastructure.Services;

public class TelegramService : ITelegramService
{
    private readonly ITelegramBotClient _telegramService;
    public TelegramService()
    {
        _telegramService = new TelegramBotClient("6134936554:AAFWci8wBTcjI7ibASwK0LnKjFtbsjHkZVc");
    }
    public async ValueTask SendMessage(TelegramMessageModel message)
    {
        ChatId chatId = new ChatId(591208356);
        await _telegramService.SendTextMessageAsync(chatId, message.ToString());
    }
}
