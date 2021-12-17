using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Servicio;
using System.Windows;

namespace Web
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoDeProductoServicio tipoServicio = new TipoDeProductoServicio();
            ProductoServicio productoServicio = new ProductoServicio();
            try
            {
                if (!IsPostBack)
                {
                    
                    List<Producto> listProducto = productoServicio.listar();
                    //Session["listaTipoProducto"] = listTipo;
                    Session["listaProducto"] = listProducto;
                    
                    List<TipoDeProducto> listTipo = tipoServicio.listar();
                    

                    ddlTipoProducto.DataSource = listTipo;
                    ddlTipoProducto.DataTextField = "Descripcion";
                    ddlTipoProducto.DataValueField = "IdTipoProducto";
                    ddlTipoProducto.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid)
                return;
            
            Producto producto = new Producto();
            ProductoServicio productoServicio = new ProductoServicio();

            producto.IdTipoProducto = int.Parse(ddlTipoProducto.SelectedItem.Value);
            producto.Precio = decimal.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);
            producto.Estado = true;
            producto.DescripcionPlato = txtNombrePlato.Text;

            productoServicio.agregar(producto);
            
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../HomeGerente.aspx",false);
        }
        protected void ddlTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(ddlTipoProducto.SelectedItem.Value);
            ddlProducto.DataSource = ((List<Producto>)Session["listaProducto"]).FindAll(x => x.IdTipoProducto == id);
            ddlProducto.DataTextField = "DescripcionPlato";
            ddlProducto.DataValueField = "IdTipoProducto";
            ddlProducto.DataBind();
        }
    }
}