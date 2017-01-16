using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class TipoTelefono
    {
        private int _TipoTelefonoId;
        private String _Nombre;

        public TipoTelefono(String nombre)
        {
            _Nombre = nombre;
        }

        public int TipoTelefonoId { get { return _TipoTelefonoId; } }
        public String Nombre { get { return _Nombre; } }
    }
}
