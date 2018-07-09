<%@ Page Title="Acceso" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Acceso.aspx.cs" Inherits="MundoDeLuz.Presentation.General.Acceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="offset-md-4 offset-lg-3 col-sm-12 col-md-4 col-lg-6">
                <div class="card bg-light">
                    <div class="card-body">
                        <h5 class="card-tittle text-center">Acceso</h5>
                        <div class="form-group">
                            <label>Usuario</label>
                            <asp:TextBox CssClass="form-control" ID="txtIdUsuario" runat="server" placeholder="Ingrese su usuario"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Contraseña</label>
                            <asp:TextBox CssClass="form-control" type="password" ID="txtPassword" runat="server" placeholder="Ingrese su contraseña"></asp:TextBox>
                        </div>
                        <asp:Button CssClass="btn btn-primary btn-block" ID="btnAcceder" runat="server" Text="Ingresar" OnClick="Event_AuthenticateUser" />
                        <a href="~/Presentation/General/RegisterUser.aspx" runat="server">Registrarse</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />    
    <br />
    <br />
</asp:Content>
