using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        ERROR=0,
        MESERO=1,
        GERENTE=2
    }
    public class Usuario
    {
        public int Id { get; set; }
        public String NombreUsuario { get; set; }
        public String Contrasena { get; set; }
        public int Tipo { get; set; }
        public Boolean Estado { get; set; }

        public Usuario() { } 

        public Usuario(string user, string pass)
        {
            NombreUsuario = user;
            Contrasena = pass;
        }

    }
}
