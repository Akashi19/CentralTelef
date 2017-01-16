
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class TipoTelefonoConfiguration : EntityTypeConfiguration<TipoTelefono>
    {
        public TipoTelefonoConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("TipoTelefono");

            //Configuro la llave primaria de la tabla TipoTelefono
            HasKey(a => a.TipoTelefonoId);

            //Configuro la longitud maxima del campo Nombre
            Property(a => a.Nombre).HasMaxLength(20);
        }
    }
}
