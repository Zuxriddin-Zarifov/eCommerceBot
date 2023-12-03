namespace eCommerceBot.Settings;

public static class AppSetting
{
    public static string NpgSqlConnection { get; set; } = "Host=localhost; Port=5432; Database=e_commerce; username=postgres; password=zuxriddin25;";
    public static string TelegramBotToken { get; set; }= "";
}