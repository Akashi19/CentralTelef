using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Fijo : Telefono
    {
        
        private int _FijoId;
        private String _Numero;

        public Fijo(String numero)
        {
            _Numero = numero;
        }

        public int FijoId { get { return _FijoId; } }
        public String Numero { get { return _Numero; } }

        public double Tarifa(int hora)
        {
           return 0.04;

        }
    }
}
