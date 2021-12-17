using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;

namespace Web.ABM_aspx.Listar
{
    public partial class ListarUsuario : System.Web.UI.Page
    {
        private List<Usuario>UsrList;
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioServicio usuarioServicio = new UsuarioServicio();
            UsrList = usuarioServicio.listar();


            UsersView.DataSource = UsrList;
            UsersView.DataBind();
        }
    }
}