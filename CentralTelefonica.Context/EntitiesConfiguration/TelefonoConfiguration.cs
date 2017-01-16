
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class TelefonoConfiguration : EntityTypeConfiguration<Telefono>
    {

        public TelefonoConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Telefono");

            //Configuro la llave primaria de la tabla Celular
            //HasKey(a => a.TelefonoId);

            //Configuro la longitud maxima del campo Nombre
            Property(a => a.Numero).HasMaxLength(10);
        }
    }
}
