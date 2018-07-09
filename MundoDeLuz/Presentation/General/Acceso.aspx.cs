using Data.CRUD;
using System;

namespace MundoDeLuz.Presentation.General
{
    public partial class Acceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["idUsuario"] != null)
                Session.Remove("idUsuario");
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
                {
                    Session["idUsuario"] = txtIdUsuario.Text.ToString().Trim().ToLower();
                    Response.Redirect("~/Presentation/Game/EleccionCategoria.aspx", false);
                }
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