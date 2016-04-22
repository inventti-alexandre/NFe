using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NFeCTe
{
    public partial class Confirmacao2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProximo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Confirmacao3.aspx");
        }
    }
}