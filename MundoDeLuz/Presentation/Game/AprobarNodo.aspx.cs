using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoDeLuz.Presentation.Game
{
    public partial class AprobarNodo : System.Web.UI.Page
    {
        ReadGeneralData readGeneralData = new ReadGeneralData();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dlstAprobarMiembro.DataSource = readGeneralData.GetDataTable("Negocio_Read_List_Nodes");
                dlstAprobarMiembro.DataBind();

            }
        }

        protected void Event_SelectProgress(object source, DataListCommandEventArgs e)
        {
            string id = dlstAprobarMiembro.DataKeys[e.Item.ItemIndex].ToString();
            Response.Redirect("~/Presentation/Game/DetailProgress.aspx?idProgress=" + id, false);
        }
    }
}