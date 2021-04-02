using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tarea7.Data.Models
{
    public partial class vacunaContext : DbContext
    {
        public vacunaContext()
        {
        }

        public vacunaContext(DbContextOptions<vacunaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Solicitante> Solicitantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder.UseSqlite("Data Source=vacuna.db");
                optionsBuilder.UseMySQL("server=db4free.net; port=3306; user=jeer_prog; password=grop_reej; database=vacunas");
            }
        }
    }
}
