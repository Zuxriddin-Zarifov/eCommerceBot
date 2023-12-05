using eCommerceBot.Domains.Sessions;

namespace eCommerceBot.TelegramBot.Managers;

public class SessionManager
{
    private List<Session> sessions { get; set; }
    
    public async Task<Session> GetSessionByChatId(long telegramChatId)
    {
        var lastSession = sessions.Find(x => x.TelegramChatId == telegramChatId);
        if (lastSession is null)
        {
            var session = new Session()
            {
                Action = null,
                Controller = null,
            };
            sessions.Add(session);
            return session;
        }

        return lastSession;
    }

    public async Task<Session?> GetSessionByClientId(long userId)
    {
        return this.sessions
            .FirstOrDefault(x => x.UserId == userId);
    }
}