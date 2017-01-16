using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class TipoIncidencia
    {
        private int _TipoIncidenciaId;
        private String _Nombre;

        public int TipoIncidenciaId { get { return _TipoIncidenciaId; } }
        public String Nombre { get { return _Nombre; } }
    }
}
