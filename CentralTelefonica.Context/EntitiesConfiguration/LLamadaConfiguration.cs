
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class LLamadaConfiguration : EntityTypeConfiguration<LLamada>
    {
        public LLamadaConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("LLamada");

            //Configuro la llave primaria de la tabla LLamada
            HasKey(a => a.LlamadaId);
            Property(a => a.Origen).HasMaxLength(250);
            Property(a => a.Destino).HasMaxLength(250);


            ////Configuro relacion Llamada - Telefono
            //HasRequired(b => b.Telefono)
            //    .WithMany(bl => bl.LLamada)
            //    .HasForeignKey(b => b.TelefonoId);

            ////Configuro relacion Llamada - Reeloj
            //HasRequired(b => b.Telefono)
            //    .WithMany(bl => bl.Reloj)
            //    .HasForeignKey(b => b.TelefonoId);
        }
    }
}
