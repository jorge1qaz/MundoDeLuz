using Data.CRUD;
using System;
using System.Collections.Generic;

namespace MundoDeLuz.Presentation.Game
{
    public partial class Dashboard : System.Web.UI.Page
    {
        public Int16 idCategoria = 1; // Cambiar
        public string idUsuario = "jricra@contasis.net"; // Cambiar 
        protected void Page_Load(object sender, EventArgs e)
        {
            //idCategoria = Convert.ToInt16(Request.QueryString["categoria"]);
            //idUsuario   = Session["idUsuario"].ToString();

            string valor;
            valor = string.Empty;

            if (!Page.IsPostBack)
            {
                FillData_PrincipalUser();

            }
        }

        public void FillData_PrincipalUser()
        {
            User userPrincipal = new User() {
                IdUsuario   = idUsuario,
                IdCategoria = idCategoria
            };
            List<string> dataPrincipalUser = new List<string>();
            try
            {
                dataPrincipalUser   = userPrincipal.GetData_PrincipalUser();
                PUlblNombres.Text   = dataPrincipalUser[0];
                PUCategoria.Text    = dataPrincipalUser[2];
                PUlblNivel.Text     = dataPrincipalUser[3];
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void FillData_PrincipalUser()
        {
            User userPrincipal = new User()
            {
                IdUsuario = idUsuario,
                IdCategoria = idCategoria
            };
            List<string> dataPrincipalUser = new List<string>();
            try
            {
                dataPrincipalUser = userPrincipal.GetData_PrincipalUser();
                PUlblNombres.Text = dataPrincipalUser[0];
                PUCategoria.Text = dataPrincipalUser[2];
                PUlblNivel.Text = dataPrincipalUser[3];
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}