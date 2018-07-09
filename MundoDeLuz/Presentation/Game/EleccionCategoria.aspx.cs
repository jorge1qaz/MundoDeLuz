using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoDeLuz.Presentation.Game
{
    public partial class EleccionCategoria : System.Web.UI.Page
    {
        public string idUsuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            boxAprobarMiembro.Visible = false;
            if (Session["idUsuario"] == null)
                Response.Redirect("~/Presentation/General/Acceso.aspx", false);
            else
            {
                idUsuario   = Session["idUsuario"].ToString();
                if (idUsuario == "mundodeluzoficial@gmail.com" || idUsuario == "jricra@contasis.net")
                    boxAprobarMiembro.Visible = true;
            }
        }

    }
}