using Data;
using Data.CRUD;
using System;

namespace MundoDeLuz.Presentation.General
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadGeneralData readGeneralData = new ReadGeneralData();
            if (!Page.IsPostBack)
            {
                lstBancos.DataSource        = readGeneralData.GetDataTable("Negocio_List_Banks");
                lstBancos.DataValueField    = "IdBanco";
                lstBancos.DataTextField     = "NombreBanco";
                lstBancos.DataBind();
            }
        }

        protected void Event_RegisterUser(object sender, EventArgs e)
        {
            try
            {
                User usuario    = new User() {
                    IdUsuario           = txtEmail.Text.ToString().Trim().ToLower(),
                    Contrasenia         = txtPassword.Text.ToString().Trim(),
                    Nombres             = txtName.Text.ToString().Trim(),
                    Apellidos           = txtApellidos.Text.ToString().Trim(),
                    NumeroTelefonico    = txtTelefono.Text.ToString().Trim(),
                    Identificacion      = txtIdentificacion.Text.ToString().Trim(),
                    IdBanco             = Convert.ToInt16(lstBancos.SelectedValue.ToString()),
                    CuentaBancaria      = txtCuentaBancaria.Text.ToString().Trim()
                };

                if (usuario.FullUser("Gen_RegisterUser"))
                    Response.Redirect("~/Presentation/Messages/Success.aspx?typeMessage=1", false);
                else
                    Response.Redirect("~/Presentation/Messages/Error.aspx?typeMessage=1", false);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Ha ocurrido un problema, contacte con el administrador. Detalle de error: ' + '" + ex + "');</script>");
            }
        }
    }
}