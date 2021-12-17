using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Session.Add("error","Debes loguearte para ingresar");
                Response.Redirect("Error.aspx");
            }
            if (((Usuario)Session["usuario"]).Tipo != 2)
            {
                Session.Add("error", "Este es el menu de gerentes, no tienes autorizacion para verlo.");
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}