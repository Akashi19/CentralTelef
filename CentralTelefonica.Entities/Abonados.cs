using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Abonados
    {
        
        private byte _AbonadosId;
        private String _Telefono;

        public Abonados(byte abonadosId, String telefono)
        {
            _Telefono = telefono;
            _AbonadosId = abonadosId;
        }

        public String Telefono { get { return _Telefono; } }
        public byte AbonadosId { get { return _AbonadosId; } }
    }
}
