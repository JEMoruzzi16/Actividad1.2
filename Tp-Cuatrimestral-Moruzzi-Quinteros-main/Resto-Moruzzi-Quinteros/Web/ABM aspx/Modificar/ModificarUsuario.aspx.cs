using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;
using System.Threading.Tasks;

namespace Web.ABM_aspx.Modificar
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioServicio usuarioServicio = new UsuarioServicio();
            Usuario aux = new Usuario();
            try
            {
                aux=usuarioServicio.buscarXUsuario(searchBox.Text);

                string nombreUsuario = aux.NombreUsuario;
                txtUsuario.Text = nombreUsuario;
                txtContrasena.Text = aux.Contrasena;
                int tipe = aux.Tipo;
                string tipo="";
                
                //switch (tipe.)
                //{
                //    case 1:
                //        tipo = "Gerente";
                //        break;
                //    case 2:
                //        tipo = "Mesero";
                //        break;
                //}
                //ddlTipo.SelectedItem.Text.Contains(tipo);


            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

    }
}