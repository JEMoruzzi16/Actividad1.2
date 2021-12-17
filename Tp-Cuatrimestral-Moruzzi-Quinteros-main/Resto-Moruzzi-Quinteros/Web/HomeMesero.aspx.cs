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
    public partial class HomeMesero1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] == null)
            {
                Session.Add("error", "Debes loguearte para ingresar");
                Response.Redirect("Error.aspx");

            }

            Mesa mesaUno,mesaDos, mesaTres, mesaCuatro,mesaCinco,mesaSeis,mesaSiete,mesaOcho;
            MesaServicio mesaServicio = new MesaServicio();
            mesaUno = mesaServicio.dibujarMesa(1);
            mesaDos = mesaServicio.dibujarMesa(2);
            mesaTres = mesaServicio.dibujarMesa(3);
            mesaCuatro = mesaServicio.dibujarMesa(4);
            mesaCinco = mesaServicio.dibujarMesa(5);
            mesaSeis = mesaServicio.dibujarMesa(6);
            mesaSiete = mesaServicio.dibujarMesa(7);
            mesaOcho = mesaServicio.dibujarMesa(8);
            lblCapacidad.Text = Convert.ToString(mesaUno.MaxCapacidad);
            lblCapacidad2.Text = Convert.ToString(mesaDos.MaxCapacidad);
            lblCapacidad3.Text = Convert.ToString(mesaTres.MaxCapacidad);
            lblCapacidad4.Text = Convert.ToString(mesaCuatro.MaxCapacidad);
            lblCapacidad5.Text = Convert.ToString(mesaCinco.MaxCapacidad);
            lblCapacidad6.Text = Convert.ToString(mesaSeis.MaxCapacidad);
            lblCapacidad7.Text = Convert.ToString(mesaSiete.MaxCapacidad);
            lblCapacidad8.Text = Convert.ToString(mesaOcho.MaxCapacidad);

            if (mesaUno.Estado == true)
            {
                lblmesaUnoEstado.Text = "Abierta";
                btnAbrirUno.Enabled = false;
            }
            else
            {
                lblmesaUnoEstado.Text = "Cerrada";
                btnAbrirUno.Enabled = true;
                btnGestionarUno.Enabled = false;
            }

            if (mesaDos.Estado == true)
            {
                lblMesaDosEstado.Text = "Abierta";
                btnAbrirDos.Enabled = false;
            }
            else
            {
                lblMesaDosEstado.Text = "Cerrada";
                btnAbrirDos.Enabled = true;
                btnGestionarDos.Enabled = false;
            }
            
            if (mesaTres.Estado == true)
            {
                lblMesaTresEstado.Text = "Abierta";
                btnAbrirTres.Enabled = false;
            }
            else
            {
                lblMesaTresEstado.Text = "Cerrada";
                btnAbrirTres.Enabled = true;
                btnGestionarTres.Enabled = false;
            }
            
            if (mesaCuatro.Estado == true)
            {
                lblMesaCuatroEstado.Text = "Abierta";
                btnAbrirCuatro.Enabled = false;
            }
            else
            {
                lblMesaCuatroEstado.Text = "Cerrada";
                btnAbrirCuatro.Enabled = true;
                btnGestionarCuatro.Enabled = false;
            }

            if (mesaCinco.Estado==true)
            {
                lblMesaCincoEstado.Text = "Abierta";
                btnAbrirCinco.Enabled = false;
            }
            else
            {
                lblMesaCincoEstado.Text = "Cerrada";
                btnAbrirCinco.Enabled = true;
                btnGestionarCinco.Enabled = false;
            }

            if (mesaSeis.Estado == true)
            {
                lblMesaSeisEstado.Text = "Abierta";
                btnAbrirSeis.Enabled = false;
            }
            else
            {
                lblMesaSeisEstado.Text = "Cerrada";
                btnAbrirSeis.Enabled = true;
                btnGestionarSeis.Enabled = false;
            }

            if (mesaSiete.Estado == true)
            {
                lblMesaSieteEstado.Text = "Abierta";
                btnAbrirSiete.Enabled = false;
            }
            else
            {
                lblMesaSieteEstado.Text = "Cerrada";
                btnAbrirSiete.Enabled = true;
                btnGestionarSiete.Enabled = false;
            }

            if (mesaOcho.Estado == true)
            {
                lblMesaOchoEstado.Text = "Abierta";
                btnAbrirOcho.Enabled = false;
            }
            else
            {
                lblMesaOchoEstado.Text = "Cerrada";
                btnAbrirOcho.Enabled = true;
                btnGestionarOcho.Enabled = false;
            }

        }


        protected void btnAbrirUno_Click(object sender, EventArgs e)
        {
            MesaServicio mesaServicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            mesaServicio.abrirMesa(1);
            btnGestionarUno.Enabled = true;
            btnAbrirUno.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1, 1);
            Session.Add("mesaUno", numeroPedido);


        }
        protected void btnAbrirDos_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(2);
            btnGestionarDos.Enabled = true;
            btnAbrirDos.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1, 2);
            Session.Add("mesaDos", numeroPedido);
        }
        protected void btnAbrirTres_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(3);
            btnGestionarTres.Enabled = true;
            btnAbrirTres.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1, 3);
            Session.Add("mesaTres", numeroPedido);
            
        }
        protected void btnAbrirCuatro_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(4);
            btnGestionarCuatro.Enabled = true;
            btnAbrirCuatro.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido=pedidosServicio.nuevo(aux.Id, 1,4);
            Session.Add("mesaCuatro",numeroPedido);

        }
        protected void btnAbrirCinco_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(5);
            btnGestionarCinco.Enabled = true;
            btnAbrirCinco.Enabled= false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1,5);
            Session.Add("mesaCinco", numeroPedido);
        }
        protected void btnAbrirSeis_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(6);
            btnGestionarSeis.Enabled = true;
            btnAbrirSeis.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1, 6);
            Session.Add("mesaSeis", numeroPedido);
        }
        protected void btnAbrirSiete_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(7);
            btnGestionarSiete.Enabled = true;
            btnAbrirSiete.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1, 7);
            Session.Add("mesaSiete", numeroPedido);
        }
        protected void btnAbrirOcho_Click(object sender, EventArgs e)
        {
            MesaServicio servicio = new MesaServicio();
            PedidoServicio pedidosServicio = new PedidoServicio();
            //Cambio De estado de la mesa
            servicio.abrirMesa(8);
            btnGestionarOcho.Enabled = true;
            btnAbrirOcho.Enabled = false;
            //Tomamos el nombre del usuario que esta logueado
            string usuario = Convert.ToString(((Usuario)Session["usuario"]).NombreUsuario);
            //Mediante el nombre, buscamos el id
            UsuarioServicio usuServicio = new UsuarioServicio();
            Usuario aux = usuServicio.buscarXUsuario(usuario);
            //Mediante el id, insertamos un nuevo pedido y obtenemos el numero de pedido
            int numeroPedido = pedidosServicio.nuevo(aux.Id, 1, 8);
            Session.Add("mesaOcho", numeroPedido);
        }



        protected void btnGestionarUno_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaUno.aspx");

        }
        protected void btnGestionarDos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaDos.aspx");
        }
        protected void btnGestionarTres_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaTres.aspx");
        }
        protected void btnGestionarCuatro_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaCuatro.aspx");
        }
        protected void btnGestionarCinco_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaCinco.aspx");
        }
        protected void btnGestionarSeis_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaSeis.aspx");

        }
        protected void btnGestionarSiete_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaSiete.aspx");

        }
        protected void btnGestionarOcho_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMesaOcho.aspx");

        }

    }
}