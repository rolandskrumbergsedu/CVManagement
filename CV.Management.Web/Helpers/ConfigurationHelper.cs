﻿using System;
using System.Configuration;

namespace CV.Management.Web.Helpers
{
    public static class ConfigurationHelper
    {
        public static string LinkedInClientId => GetConfigurationValue("LinkedInClientId");
        public static string LinkedInClientKey => GetConfigurationValue("LinkedInClientKey");
        public static string Database => GetConfigurationValue("AmropDb");


        private static string GetConfigurationValue(string configurationValueName)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[configurationValueName];

            if (connectionString == null)
            {
                throw new Exception($"Failed to get {configurationValueName}");
            }

            var returnValue = connectionString.ConnectionString;

            if (string.IsNullOrEmpty(returnValue))
            {
                var variableFromEnvironment = Environment.GetEnvironmentVariable(configurationValueName);

                if (string.IsNullOrEmpty(variableFromEnvironment))
                {
                    throw new Exception($"Empty {configurationValueName} value");
                }

                return variableFromEnvironment;
            }

            return returnValue;
        }
    }
}