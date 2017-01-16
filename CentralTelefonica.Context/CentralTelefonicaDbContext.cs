
using CentralTelefonica.Entities;
using System.Data.Entity;

using CentralTelefonica.Context.EntitiesConfiguration;

namespace CentralTelefonica.Context
{
    class CentralTelefonicaDbContext : DbContext
    {
        public DbSet<Celular> Celular { get; set; }

        public DbSet<Central> Central { get; set; }

        public DbSet<Fijo> Fijo { get; set; }

        public DbSet<LLamada> LLamada { get; set; }

        public DbSet<Reloj> Reloj { get; set; }

        public DbSet<Telefono> Telefono { get; set; }

        public DbSet<Time> Time { get; set; }

        public DbSet<Abonados> Abonados { get; set; }

        public DbSet<Incidencia> Incidencia { get; set; }

        public DbSet<RegistroHistorico> RegistroHistorico { get; set; }

        public DbSet<RegistroIncidencia> RegistroIncidencia { get; set; }

        public DbSet<TipoIncidencia> TipoIncidencia { get; set; }

        public DbSet<TipoTelefono> TipoTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbonadosConfiguration());

            modelBuilder.Configurations.Add(new CelularConfiguration());

            modelBuilder.Configurations.Add(new CentralConfiguration());

            modelBuilder.Configurations.Add(new FijoConfiguration());

            modelBuilder.Configurations.Add(new IncidenciaConfiguration());

            modelBuilder.Configurations.Add(new LLamadaConfiguration());

            modelBuilder.Configurations.Add(new RegistroHistoricoConfiguration());

            modelBuilder.Configurations.Add(new RegistroIncidenciaConfiguration());

            modelBuilder.Configurations.Add(new RelojConfiguration());

            modelBuilder.Configurations.Add(new TelefonoConfiguration());

            modelBuilder.Configurations.Add(new TimeConfiguration());

            modelBuilder.Configurations.Add(new TipoIncidenciaConfiguration());

            modelBuilder.Configurations.Add(new RegistroIncidenciaConfiguration());

            modelBuilder.Configurations.Add(new RelojConfiguration());

            modelBuilder.Configurations.Add(new TipoTelefonoConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
