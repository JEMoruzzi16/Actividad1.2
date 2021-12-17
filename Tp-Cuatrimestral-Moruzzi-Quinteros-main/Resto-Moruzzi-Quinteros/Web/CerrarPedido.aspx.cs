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
    public partial class CerrarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MetodoDePagoServicio metodo = new MetodoDePagoServicio();
            

            try
            {
                if (!IsPostBack)
                {
                    lblNroPedido.Text = Session["nroPedido"].ToString();
                    lblMonto.Text = Session["monto"].ToString();
                    

                    ddlMetodoPago.DataSource = metodo.listar();
                    ddlMetodoPago.DataValueField = "Descripcion";
                    ddlMetodoPago.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeMesero.aspx",false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            PedidoServicio pedidoServicio = new PedidoServicio();
            MetodoDePagoServicio metodoServicio = new MetodoDePagoServicio();
            MesaServicio mesaServicio = new MesaServicio();

            try
            {                
                pedido.NumeroPedido = (int)Session["nroPedido"];
                pedido.Fecha = DateTime.Now;

                Usuario aux=(Usuario)Session["usuario"];
                pedido.UsuarioMesero = aux.NombreUsuario;
                string metodoPago=ddlMetodoPago.SelectedItem.Value;
                pedido.IdMetodoPago = metodoServicio.metodoPorDescripcion(metodoPago);
                pedido.nroMesa = (int)Session["mesa"];
                pedido.Estado = false;
                pedido.Monto = Convert.ToDecimal(lblMonto.Text);

                pedidoServicio.grabarPedido(pedido);

                mesaServicio.cerrarMesa(pedido.nroMesa);


                string msg = "Pedido guardado con éxito.";
                ScriptManager.RegisterStartupScript(this, this.GetType(),
               "alert",
               "alert('" + msg + "');window.location ='HomeMesero.aspx';", true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}