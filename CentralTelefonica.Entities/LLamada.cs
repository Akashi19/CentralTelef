using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class LLamada
    {
        public int _LlamadaId;
        private Telefono _Telefono;
        public int TelefonoId { get; set; }
        private Reloj _Reloj;
        public int RelojId { get; set; }
        private String _Origen;
        private String _Destino;
     

        public LLamada(String numero)
        {
            if (numero[0] == '9')
                _Telefono = new Celular(numero);
            else
                _Telefono = new Fijo(numero);

            _Reloj = new Reloj();
        }

        public Telefono Telefono { get { return _Telefono; } }
        public Reloj Reloj { get { return _Reloj; } }
        public int LlamadaId { get { return _LlamadaId; } }
        public String Origen { get { return _Origen; } }
        public String Destino { get { return _Destino; } }

        public double Tarifa()
        {
          
            return _Telefono.Tarifa(DateTime.Now.Hour);
        }
    }
}
