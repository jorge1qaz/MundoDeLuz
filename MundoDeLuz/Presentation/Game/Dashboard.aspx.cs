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
        public List<LowerNode>      lowerNodes = new List<LowerNode>();
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
                Get_List_LowerNodes();
                Fill_List_LowerNodes();
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

        // Instanciar la lista de Ids
        public List<string> Get_List_LowerNodes()
        {
            ReadGeneralData readGeneralData = new ReadGeneralData();
            List<string> values             = readGeneralData.GetListValuesById("Negocio_GetData_LowerNodes_IDS_ByIdTopNode", "@NodoSuperior", idUsuario);
            return values;
        }
        
        public void Fill_List_LowerNodes()
        {
            principalIdsUsers = Get_List_LowerNodes();
            LowerNode lowerNode;
            if (principalIdsUsers.Count >= 1)
                for (int i = 0; i < principalIdsUsers.Count; i++)
                {
                    lowerNode   = new LowerNode();
                    lowerNodes.Add(lowerNode);
                    lowerNodes[i]   = FillLowerNodes(principalIdsUsers[i]);
                }
        }
        
        public void FillData_EachBox()
        {
            try
            {
                switch (principalIdsUsers.Count)
                {
                    case 0:
                        // No existe ningún miembro
                        break;
                    case 1:
                        LN1lblNombres.Text          = lowerNodes[0].Nombres;
                        LN1lblActualNivel.Text      = lowerNodes[0].NombreNivel;
                        LN1lblColaboradores.Text    = lowerNodes[0].Cantidad.ToString();
                        break;
                    case 2:
                        LN1lblNombres.Text          = lowerNodes[0].Nombres;
                        LN1lblActualNivel.Text      = lowerNodes[0].NombreNivel;
                        LN1lblColaboradores.Text    = lowerNodes[0].Cantidad.ToString();

                        LN2lblNombres.Text          = lowerNodes[1].Nombres;
                        LN2lblActualNivel.Text      = lowerNodes[1].NombreNivel;
                        LN2lblColaboradores.Text    = lowerNodes[1].Cantidad.ToString();
                        break;
                    case 3:
                        LN1lblNombres.Text          = lowerNodes[0].Nombres;
                        LN1lblActualNivel.Text      = lowerNodes[0].NombreNivel;
                        LN1lblColaboradores.Text    = lowerNodes[0].Cantidad.ToString();

                        LN2lblNombres.Text          = lowerNodes[1].Nombres;
                        LN2lblActualNivel.Text      = lowerNodes[1].NombreNivel;
                        LN2lblColaboradores.Text    = lowerNodes[1].Cantidad.ToString();

                        LN3lblNombres.Text          = lowerNodes[2].Nombres;
                        LN3lblActualNivel.Text      = lowerNodes[2].NombreNivel;
                        LN3lblColaboradores.Text    = lowerNodes[2].Cantidad.ToString();
                        break;
                    case 4:
                        LN1lblNombres.Text          = lowerNodes[0].Nombres;
                        LN1lblActualNivel.Text      = lowerNodes[0].NombreNivel;
                        LN1lblColaboradores.Text    = lowerNodes[0].Cantidad.ToString();

                        LN2lblNombres.Text          = lowerNodes[1].Nombres;
                        LN2lblActualNivel.Text      = lowerNodes[1].NombreNivel;
                        LN2lblColaboradores.Text    = lowerNodes[1].Cantidad.ToString();

                        LN3lblNombres.Text          = lowerNodes[2].Nombres;
                        LN3lblActualNivel.Text      = lowerNodes[2].NombreNivel;
                        LN3lblColaboradores.Text    = lowerNodes[2].Cantidad.ToString();

                        LN4lblNombres.Text          = lowerNodes[3].Nombres;
                        LN4lblActualNivel.Text      = lowerNodes[3].NombreNivel;
                        LN4lblColaboradores.Text    = lowerNodes[3].Cantidad.ToString();
                        break;

                    case 5:
                        LN1lblNombres.Text          = lowerNodes[0].Nombres;
                        LN1lblActualNivel.Text      = lowerNodes[0].NombreNivel;
                        LN1lblColaboradores.Text    = lowerNodes[0].Cantidad.ToString();

                        LN2lblNombres.Text          = lowerNodes[1].Nombres;
                        LN2lblActualNivel.Text      = lowerNodes[1].NombreNivel;
                        LN2lblColaboradores.Text    = lowerNodes[1].Cantidad.ToString();

                        LN3lblNombres.Text          = lowerNodes[2].Nombres;
                        LN3lblActualNivel.Text      = lowerNodes[2].NombreNivel;
                        LN3lblColaboradores.Text    = lowerNodes[2].Cantidad.ToString();

                        LN4lblNombres.Text          = lowerNodes[3].Nombres;
                        LN4lblActualNivel.Text      = lowerNodes[3].NombreNivel;
                        LN4lblColaboradores.Text    = lowerNodes[3].Cantidad.ToString();

                        LN5lblNombres.Text          = lowerNodes[4].Nombres;
                        LN5lblActualNivel.Text      = lowerNodes[4].NombreNivel;
                        LN5lblColaboradores.Text    = lowerNodes[4].Cantidad.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Add_Partner()
        {
            Progress progress = new Progress() {
                NodoSuperior = idUsuario,
                NodoInferior = txtAddPartner.Text.ToString(),
                IdCategoria = idCategoria
            };

            if (progress.CreateProgress())
                Response.Redirect("~/Presentation/Messages/Success.aspx?typeMessage=1", false); // indicar 
            else
                Response.Redirect("~/Presentation/Messages/Error.aspx?typeMessage=1", false);
        }
    }
}