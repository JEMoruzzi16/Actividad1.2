using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;

namespace Web
{
    public partial class Logueo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btInitSession_Click(object sender, EventArgs e)
        {
            
            UsuarioServicio usuarioServicio = new UsuarioServicio();

            try
            {
                Usuario usuario = new Usuario(txtUsuario.Text,txtPass.Text);
                if(usuarioServicio.Loguear(usuario).Tipo == 1){
                    Session.Add("usuario", usuario);
                    Response.Redirect("HomeMesero.aspx",false);
                }else if(usuarioServicio.Loguear(usuario).Tipo == 2){
                    Session.Add("usuario", usuario);
                    Response.Redirect("HomeGerente.aspx",false);
                }else{
                    Session.Add("error", "User o pass incorrectos");
                    Response.Redirect("error.aspx",false);
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx",false);
            }


        }
    }
}