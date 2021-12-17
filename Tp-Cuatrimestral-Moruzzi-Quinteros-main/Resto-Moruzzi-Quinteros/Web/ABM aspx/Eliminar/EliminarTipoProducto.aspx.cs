using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicio;
using Dominio;


namespace Web.ABM_aspx.Eliminar
{
    public partial class EliminarTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoDeProductoServicio tipoServicio = new TipoDeProductoServicio();
            if (!IsPostBack)
            {
                List<TipoDeProducto> listTipo = tipoServicio.listarConDDL();

                ddlTipo.DataSource = listTipo;
                ddlTipo.DataTextField = "Descripcion";
                ddlTipo.DataValueField = "IdTipoProducto";
                ddlTipo.DataBind();
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
           /*NO elimina, hay un temita con el SelectedItem.Value, con el punto de 
            * interrupcion correbore y toma un valor siempre 0
            * */
            TipoDeProducto tipo = new TipoDeProducto();
            TipoDeProductoServicio servicio = new TipoDeProductoServicio();
            try
            {
                
                int idPrueba=int.Parse(ddlTipo.SelectedItem.Value);
                tipo.IdTipoProducto = idPrueba;
                servicio.eliminar(tipo);
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