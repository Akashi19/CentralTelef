
using System.Data.Entity.ModelConfiguration;
using CentralTelefonica.Entities;

namespace CentralTelefonica.Context.EntitiesConfiguration
{
    class TimeConfiguration : EntityTypeConfiguration<Time>
    {
        public TimeConfiguration()
        {
            //Configuro el nombre de la tabla en la base de datos
            ToTable("Time");

            //Configuro la llave primaria de la tabla Time
            HasKey(a => a.TimeId);


        }
    }
}
