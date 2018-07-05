using Business;
using Business.Logic;
using Data;
using Data.CRUD;
using System;
using System.Collections.Generic;

namespace MundoDeLuz.Presentation.Game
{
    public partial class Dashboard : System.Web.UI.Page
    {
        public Int16 idCategoria = 1; // Cambiar
        public string idUsuario = "valornuevo@gmail.com"; // Cambiar 
        public List<string> principalIdsUsers = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //idCategoria = Convert.ToInt16(Request.QueryString["categoria"]);
            //idUsuario   = Session["idUsuario"].ToString();

            string valor;
            valor = string.Empty;

            if (!Page.IsPostBack)
            {
                GetPrincipalNodes(); // Aquí ya se termino de llenar la lista y esta disponible para hacer las consultas
                FillData_PrincipalUser();

            }
        }
        public void FillData_PrincipalUser()
        {
            try
            {
                #region Principal User
                PrincipalUser user              = new PrincipalUser() {
                    IdUsuario = idUsuario,
                    IdCategoria = idCategoria
                };
                PrincipalUserData principalUser = new PrincipalUserData();
                user = principalUser.FillData(user);
                
                PUlblNombres.Text   = user.Nombres;
                PUCategoria.Text    = user.NombreCategoria;
                PUlblNivel.Text     = user.NombreNivel;
                #endregion Principal User

                #region Principal User Status
                ReadGeneralData readGeneralData = new ReadGeneralData();
                int valueNextlevel; // Variable temporal para asignar el nivel

                if (Convert.ToInt32(user.IdNivel) <= 2)
                    valueNextlevel  = Convert.ToInt32(user.IdNivel) + 1;
                else
                    valueNextlevel  = Convert.ToInt32(user.IdNivel);

                PUlblSiguienteNivel.Text    = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", Convert.ToInt16(valueNextlevel));

                PUlblCantidadColaboradores.Text = Convert.ToString(readGeneralData.GetSingleValueINTById("Negocio_GetData_LowerNodes_ById", "@NodoSuperior", idUsuario)); // idUsuario obtenido previamente

                GrlLblNombreNivel1.Text = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", 1);
                GrlLblNombreNivel2.Text = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", 2);
                GrlLblNombreNivel3.Text = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", 3);

                PULblGananciaNivel1.Text = Convert.ToString(readGeneralData.GetSingleValueDECIMAL_ByTwoIds("Negocio_GetData_Achievements_ByIdUser", "@NodoSuperior", idUsuario, "@IdNivel", 1));
                PULblGananciaNivel2.Text = Convert.ToString(readGeneralData.GetSingleValueDECIMAL_ByTwoIds("Negocio_GetData_Achievements_ByIdUser", "@NodoSuperior", idUsuario, "@IdNivel", 2));
                PULblGananciaNivel3.Text = Convert.ToString(readGeneralData.GetSingleValueDECIMAL_ByTwoIds("Negocio_GetData_Achievements_ByIdUser", "@NodoSuperior", idUsuario, "@IdNivel", 3));

                #endregion Principal User Status


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void GetPrincipalNodes()
        {
            ReadGeneralData readGeneralData = new ReadGeneralData();
            principalIdsUsers = readGeneralData.GetListValuesById("Negocio_GetData_LowerNodes_IDS_ByIdTopNode", "@NodoSuperior", idUsuario);
        }


        public void FillData_PrincipalUser_logros()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}