using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Mesero
    {
        public String NombreUsuario { get; set; }
        public List<Mesa> MesasAsignadas { get; set; }
        public void AbrirMesa() { }
        public void CerrarMesa() { }

    }
}
