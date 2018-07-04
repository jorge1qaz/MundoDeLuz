using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoDeLuz.Presentation.Messages
{
    public partial class Success : System.Web.UI.Page
    {
        static string headerRegistroUsuario = "¡Registro con éxito!";
        static string bodyRegistroUsuario   = "Se ha registrado con éxito..."; // Completar mensaje
        
        static int tipoMensaje = 0;
        static string nameCostumer = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            tipoMensaje = Convert.ToInt32(Request.QueryString["typeMessage"]);
            linkButton.Visible = false;
            switch (tipoMensaje)
            {
                case 1:
                    lblHeader.Text              = headerRegistroUsuario;
                    lblMensajePrincipal.Text    = bodyRegistroUsuario;
                    break;
                default:
                    Response.Redirect("~/Presentation/Messages/Error.aspx?typeMessage=1");
                    break;
            }
        }
    }
}