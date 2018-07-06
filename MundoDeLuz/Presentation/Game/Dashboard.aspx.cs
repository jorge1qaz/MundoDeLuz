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
        public Int16 idCategoria    = 1; // Cambiar
        public string idUsuario     = "jricra@contasis.net"; // Cambiar 
        public List<string>         principalIdsUsers;
        public List<LowerNode>      lowerNodes;
        public int conteoNodosinferiores;
        protected void Page_Load(object sender, EventArgs e)
        {
            //idCategoria = Convert.ToInt16(Request.QueryString["categoria"]);
            //idUsuario   = Session["idUsuario"].ToString();

            string valor;
            valor = string.Empty;
            if (!Page.IsPostBack)
            {
                FillData_PrincipalUser();
                FillLowerNodes();
                FillData_EachBox();
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

                conteoNodosinferiores = user.Cantidad;
                #endregion Principal User

                #region Principal User Status
                ReadGeneralData readGeneralData = new ReadGeneralData();
                int valueNextlevel; // Variable temporal para asignar el nivel

                if (Convert.ToInt32(user.IdNivel) <= 2)
                    valueNextlevel  = Convert.ToInt32(user.IdNivel) + 1;
                else
                    valueNextlevel  = Convert.ToInt32(user.IdNivel);

                PUlblSiguienteNivel.Text            = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", Convert.ToInt16(valueNextlevel));

                PUlblCantidadColaboradores.Text     = Convert.ToString(readGeneralData.GetSingleValueINTById("Negocio_GetData_LowerNodes_ById", "@NodoSuperior", idUsuario)); // idUsuario obtenido previamente
                PUlblCantidadColaboradores2.Text    = Convert.ToString(readGeneralData.GetSingleValueINTById("Negocio_GetData_LowerNodes_ById", "@NodoSuperior", idUsuario));

                GrlLblNombreNivel1.Text     = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", 1);
                GrlLblNombreNivel2.Text     = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", 2);
                GrlLblNombreNivel3.Text     = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Level_Name", "@IdNivel", 3);

                PULblGananciaNivel1.Text    = Convert.ToString(readGeneralData.GetSingleValueDECIMAL_3Ids("Negocio_GetData_Achievements_ByIdUser", "@NodoSuperior", idUsuario, "@IdNivel", 1, "@IdCategoria", idCategoria));
                PULblGananciaNivel2.Text    = Convert.ToString(readGeneralData.GetSingleValueDECIMAL_3Ids("Negocio_GetData_Achievements_ByIdUser", "@NodoSuperior", idUsuario, "@IdNivel", 2, "@IdCategoria", idCategoria));
                PULblGananciaNivel3.Text    = Convert.ToString(readGeneralData.GetSingleValueDECIMAL_3Ids("Negocio_GetData_Achievements_ByIdUser", "@NodoSuperior", idUsuario, "@IdNivel", 3, "@IdCategoria", idCategoria));

                #endregion Principal User Status


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public LowerNode FillLowerNodes(string idNodoInferior)
        {
            LowerNode lowerNode = new LowerNode()
            {
                NodoSuperior = idNodoInferior,
                IdCategoria = idCategoria
            };

            LowerNodeData lowerNodeData = new LowerNodeData();
            lowerNode = lowerNodeData.FillData(lowerNode);

            return lowerNode;
        }

        public List<string> Get_List_LowerNodes()
        {
            ReadGeneralData readGeneralData = new ReadGeneralData();
            List<string> values             = readGeneralData.GetListValuesById("Negocio_GetData_LowerNodes_IDS_ByIdTopNode", "@NodoSuperior", idUsuario);
            return values;
        }
        
        public void FillLowerNodes()
        {
            principalIdsUsers = Get_List_LowerNodes();

            if(principalIdsUsers.Count >= 1)
                for (int i = 0; i < principalIdsUsers.Count; i++)
                    lowerNodes[i]   = FillLowerNodes(principalIdsUsers[i]);
        }
        
        public void FillData_EachBox()
        {
            try
            {
                LN1lblNombres.Text      = lowerNodes[1].Nombres;
                LN1lblActualNivel.Text  = lowerNodes[1].NombreNivel;
                LN1lblColaboradores.Text = lowerNodes[1].Cantidad.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}