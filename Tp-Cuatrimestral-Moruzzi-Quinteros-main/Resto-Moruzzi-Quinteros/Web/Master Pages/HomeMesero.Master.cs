using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class HomeMesero : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoOut_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("./Logueo.aspx", false);
        }
    }
}