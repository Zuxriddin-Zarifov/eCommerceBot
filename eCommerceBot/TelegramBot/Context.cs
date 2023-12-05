using eCommerceBot.Domains.Sessions;
using Telegram.Bot.Types;

namespace eCommerceBot.TelegramBot;

public class Context
{
    public Update Update { get; set; }
    public Message Message => Update?.Message;
    public Session Session { get; set; }
}