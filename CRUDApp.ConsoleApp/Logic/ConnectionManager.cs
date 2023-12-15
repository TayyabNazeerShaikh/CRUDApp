using Microsoft.Extensions.Configuration;

namespace CRUDApp.ConsoleApp.Logic
{
    public class ConnectionManager
    {
        IConfiguration configuration = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json")
         .Build();
        public string GetConnectionString()
        {
            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}
