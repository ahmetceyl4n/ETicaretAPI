using Microsoft.Extensions.Configuration;
using System.IO;

namespace ETicaretAPI.Persistence
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();

                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                    "../../Presentation/ETicaretAPI.API")); // appsettings.json dosyasının yolu

                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
