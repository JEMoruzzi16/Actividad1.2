using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio;
using Dominio;

namespace Web
{
    public partial class AgregarTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
            TipoDeProducto tipo = new TipoDeProducto();
            TipoDeProductoServicio serviciotipo = new TipoDeProductoServicio();
            try
            {
                tipo.Descripcion = txbNombre.Text;
                serviciotipo.agregar(tipo);
            }
            catch (Exception ex)
            { 
                throw ex;
            }       
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../HomeGerente.aspx",false);
        }
    }
}