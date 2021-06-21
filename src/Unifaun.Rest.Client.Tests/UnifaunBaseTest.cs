using System;
using Microsoft.Extensions.Configuration;

namespace Unifaun.Rest.Client.Tests
{
    public abstract class UnifaunBaseTest
    {
        protected readonly UnifaunRestClient Client = new UnifaunRestClient
        {
            ApiKey = GetUnifaunApiKey()
        };

        public static string GetUnifaunApiKey()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json", false)
                .Build();

            return config["ApiKey"];
        }
    }
}