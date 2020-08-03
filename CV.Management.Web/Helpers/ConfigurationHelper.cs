using Microsoft.Ajax.Utilities;
using System;
using System.Configuration;

namespace CV.Management.Web.Helpers
{
    public static class ConfigurationHelper
    {
        public static string LinkedInClientId => GetConfigurationValue("LinkedInClientId");
        public static string LinkedInClientKey => GetConfigurationValue("LinkedInClientKey");
        public static string Database => GetConfigurationValue("AmropDb");
        public static string SendGridKey => GetConfigurationValue("AmropSendGridKey");

        private static string GetConfigurationValue(string configurationValueName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[configurationValueName];

            if (connectionString == null || string.IsNullOrEmpty(connectionString.ConnectionString))
            {
                var variableFromAppSettings = ConfigurationManager.AppSettings[configurationValueName];

                if (variableFromAppSettings == null || string.IsNullOrEmpty(variableFromAppSettings))
                {
                    var variableFromEnvironment = Environment.GetEnvironmentVariable(configurationValueName);

                    if (string.IsNullOrEmpty(variableFromEnvironment))
                    {
                        throw new Exception($"Empty {configurationValueName} value");
                    }

                    return variableFromEnvironment;
                }

                return variableFromAppSettings;
            }

            return connectionString.ConnectionString;
        }
    }
}