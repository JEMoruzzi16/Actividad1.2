using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;


namespace Web.ABM_aspx.Modificar
{
    public partial class ModificarTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoDeProductoServicio tipoServicio = new TipoDeProductoServicio();
            try
            {
                if (!IsPostBack)
                {
                   // txtNombre.Enabled = false;
                    List<TipoDeProducto> listTipo = tipoServicio.listar();

                    ddlTipos.DataSource = listTipo;
                    ddlTipos.DataTextField = "Descripcion";
                    ddlTipos.DataValueField = "IdTipoProducto";
                    ddlTipos.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
            TipoDeProducto tipo = new TipoDeProducto();
            TipoDeProductoServicio servicio = new TipoDeProductoServicio();
            try
            {
                tipo.Descripcion = txtNombre.Text;
                tipo.IdTipoProducto = int.Parse(ddlTipos.SelectedItem.Value);
                servicio.modificar(tipo);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../HomeGerente.aspx", false);
        }
    }
}