using Telegram.Bot;

namespace eCommerceBot.TelegramBot;

public class TelegramBot
{
    public static TelegramBotClient _client { get; set; }

    private List<Func<Context, CancellationToken, Task>> updateHandlers { get; set; }
    
    public async Task Start()
    {
        
    }
}