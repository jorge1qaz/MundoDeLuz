using Data.CRUD;
using System;

namespace MundoDeLuz.Presentation.General
{
    public partial class Acceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Event_AuthenticateUser(object sender, EventArgs e)
        {
            try
            {
                User usuario = new User()
                {
                    IdUsuario = txtIdUsuario.Text.ToString().Trim().ToLower(),
                    Contrasenia = txtPassword.Text.ToString().Trim()
                };

                if (usuario.AuthenticateUser())
                    Response.Redirect("~/Presentation/Game/Dashboard.aspx", false);
                else
                    Response.Write("<script>alert('Datos incorrectos!');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un problema, contacte con el administrador. Detalle de error: ' + '" + ex + "');</script>");
            }
        }
    }
}