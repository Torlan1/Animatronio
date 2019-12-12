using System.Configuration;

namespace Animatronio.Settings
{
    public class Config 
    {
        public static string GetConfigValue(string key, string defaultValue)
        {
            var setting = ConfigurationManager.AppSettings[key];
            if (setting == null)
            {
                return defaultValue;
            }
            return setting;
        }

        public string GetBaseUrl()
        {
            return ConfigurationManager.AppSettings["BaseUrl"];
        }

        public int ElementTimeOutMs()
        {
            var timeOut = ConfigurationManager.AppSettings["ElementTimeOutMs"];
            return int.Parse(timeOut);
        }
    }
}