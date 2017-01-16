
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class RelojConfiguration : EntityTypeConfiguration<Reloj>
    {
        public RelojConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Reloj");

            //Configuro la llave primaria de la tabla Reloj
            HasKey(a => a.RelojId);

            //Configuro la longitud maxima del campo GetTime
            Property(a => a.GetTime());
        }
    }
}
