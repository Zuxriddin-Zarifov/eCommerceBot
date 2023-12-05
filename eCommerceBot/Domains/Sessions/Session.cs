using eCommerceBot.Domains.Dtos;
using Telegram.Bot.Types;

namespace eCommerceBot.Domains.Sessions;

public class Session
{
    public long TelegramChatId { get; set; }
    public long UserId { get; set; }
    public string Action { get; set; }
    public string Controller { get; set; }
    public UserCreateDto UserCreateDto { get; set; }
}