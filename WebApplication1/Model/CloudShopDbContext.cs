using Microsoft.EntityFrameworkCore;
using WebApplication1.Model.Entity;

namespace WebApplication1.Model
{
    public class CloudShopDbContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // получаем файл конфигурации
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            // устанавливаем для контекста строку подключения
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("CloudDBConnectingString"));
        }

    }
}
