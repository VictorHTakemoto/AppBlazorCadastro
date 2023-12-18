using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using SmartHint.Model.Entity;
using System.Configuration;

namespace SmartHint.DAL.Model
{
    public partial class smartHintDBContext : DbContext
    {
        public smartHintDBContext() { }
        public smartHintDBContext
            (DbContextOptions<smartHintDBContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string paramsJson = AppContext.BaseDirectory + "\\params.json";
            JObject globalParams = JObject.Parse(File.ReadAllText(paramsJson));
            try
            {
                if (globalParams["NomeAppSettings"] != null && globalParams["DBConnection"] != null)
                {
                    IConfigurationRoot config = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile(globalParams["NomeAppSettings"].ToString())
                        .Build();
                    if (!optionsBuilder.IsConfigured)
                    {
                        var serverVersion = new MySqlServerVersion(new Version(8,0,35));
                        var teste = config.GetConnectionString(globalParams["DBConnection"].ToString());
                        optionsBuilder.UseMySql(teste, serverVersion);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu Ruim: " + ex);
            }
        }
        public DbSet<CustomerBase> CustomerBases { get; set; }
        public DbSet<CustomerDocument> CustomerDocuments { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
    }
}
