using System.Configuration;

namespace Blog.Generator
{
    public class BlogSettings
    {
        public static string BaseRef { get; set; } = GetSetting(nameof(BaseRef));
        public static string ContactEmail { get; set; } = GetSetting(nameof(ContactEmail));
        public static string ServerUri { get; set; } = GetSetting(nameof(ServerUri));
        public static string Title { get; set; } = GetSetting(nameof(Title));
        public static string Description { get; set; } = GetSetting(nameof(Description));
        public static string GoogleAnalytics { get; set; } = GetSetting(nameof(GoogleAnalytics));
        public static string Lang { get; set; } = GetSetting(nameof(Lang));

        private static string GetSetting(string name) => ConfigurationManager.AppSettings[name];
    }
}