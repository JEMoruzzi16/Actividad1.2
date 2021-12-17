using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Gerente
    {
        public String Usuario { get; set; }
        public List<Mesa> Mesas { get; set; }
        public void AbrirMesa() { }
        public void CerrarMesa() { }
        public void AgregarStock() { }

    }
}
