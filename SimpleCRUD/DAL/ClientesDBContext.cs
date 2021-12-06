using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace SimpleCRUD.DAL
{
    public partial class ClientesDBContext : DbContext
    {
        public ClientesDBContext()
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()

               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();

                string connectionString = configuration.GetConnectionString("conn_string_clientes");

                optionsBuilder.UseSqlite(connectionString);
            }
        }
    }
}
