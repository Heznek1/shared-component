using System.Configuration;

namespace Shared.Security
{
    public static class Token
    {
        private static readonly string secretKey = "Secret";

        public static string GetSecretKey()
        {
            return ConfigurationManager.AppSettings[secretKey];
        }
    }
}