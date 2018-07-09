using Data;
using Data.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoDeLuz.Presentation.Game
{
    public partial class DetailProgress : System.Web.UI.Page
    {
        ReadGeneralData readGeneralData = new ReadGeneralData();
        public string idProgresQuery;
        protected void Page_Load(object sender, EventArgs e)
        {
            Progresos progresos = new Progresos();
            Progress progress   = new Progress();
            User user = new User();
            Usuarios nodoSuperior = new Usuarios();
            Usuarios nodoInferior = new Usuarios();
            try
            {
                if (!Page.IsPostBack)
                {
                    idProgresQuery      = Request.QueryString["idProgress"].ToString();
                    progresos           = progress.Read(Request.QueryString["idProgress"].ToString());
                    lblCategoria.Text   = readGeneralData.GetSingleValueSTRINGById("Negocio_GetData_Categoria_Name", "@NombreCategoria", progresos.IdCategoria);
                    nodoSuperior        = user.Read(progresos.NodoSuperior);
                    NSlblNombres.Text   = nodoSuperior.Nombres;
                    NSlblApellidos.Text = nodoSuperior.Apellidos;
                    NSlblTelefono.Text  = nodoSuperior.NumeroTelefonico;
                    NSlblIdUsuario.Text = nodoSuperior.IdUsuario;
                    nodoInferior        = user.Read(progresos.NodoInferior);
                    NIlblNombres.Text   = nodoInferior.Nombres;
                    NIlblApellidos.Text = nodoInferior.Apellidos;
                    NIlblTelefono.Text  = nodoInferior.NumeroTelefonico;
                    NIlblIdUsuario.Text = nodoInferior.IdUsuario;
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("~/Presentation/General/Acceso.aspx", false);
            }

        }
        

        protected void Event_Rechazar(object sender, EventArgs e)
        {
            string idProgres = Request.QueryString["idProgress"].ToString();
            Progresos progresos     = new Progresos();
            Progress progress       = new Progress();
            User user               = new User();
            Usuarios nodoSuperior   = new Usuarios();
            Usuarios nodoInferior   = new Usuarios();
            progresos               = progress.Read(Request.QueryString["idProgress"].ToString());
            nodoSuperior            = user.Read(progresos.NodoSuperior);
            nodoInferior            = user.Read(progresos.NodoInferior);

            Progress progressDelete = new Progress() {
                NodoSuperior    = nodoSuperior.IdUsuario,
                NodoInferior    = nodoInferior.IdUsuario,
                IdCategoria     = progresos.IdCategoria,
                IdProgreso      = Convert.ToInt32(idProgres)
            };
            if (progressDelete.DeleteProgress())
            {
                Response.Write("<script>alert('Miembro eliminado con éxito.');</script>");
                Response.Redirect("~/Presentation/Game/DetailProgress.aspx?idProgress=" + idProgres, false);
            }
            else
                Response.Write("<script>alert('No se puede eliminar al miembro, contacte al administrador.');</script>");
        }
        
        protected void Event_Aceptar(object sender, EventArgs e)
        {
            string idProgres = Request.QueryString["idProgress"].ToString();
            Progresos progresos     = new Progresos();
            Progress progress       = new Progress();
            User user               = new User();
            Usuarios nodoSuperior   = new Usuarios();
            Usuarios nodoInferior   = new Usuarios();
            progresos               = progress.Read(Request.QueryString["idProgress"].ToString());
            nodoSuperior            = user.Read(progresos.NodoSuperior);
            nodoInferior            = user.Read(progresos.NodoInferior);

            Progress progressUpdate = new Progress() {
                IdProgreso      = Convert.ToInt32(idProgres)
            };
            if (progressUpdate.UpdateProgress())
            {
                Response.Write("<script>alert('Miembro aprobado con éxito.');</script>");
                Response.Redirect("~/Presentation/Game/DetailProgress.aspx?idProgress=" + idProgres, false);
            }
            else
                Response.Write("<script>alert('No se puede aprobar al miembro, contacte al administrador.');</script>");
        }
    }
}