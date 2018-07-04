<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="MundoDeLuz.Presentation.General.RegisterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="offset-md-4 offset-lg-3 col-sm-12 col-md-4 col-lg-6">
                <div class="card bg-light">
                    <div class="card-body">
                        <h5 class="card-tittle text-center">Registro de nuevo miembro</h5>
                        <div class="form-group">
                            <label>Correo electrónico</label>
                            <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" AutoCompleteType="Email" placeholder="Ingrese su correo electrónico"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Contraseña</label>
                            <asp:TextBox CssClass="form-control" ID="txtPassword" Type="password" runat="server" placeholder="Ingrese una contraseña segura" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Nombre(s)</label>
                            <asp:TextBox CssClass="form-control" ID="txtName" runat="server" placeholder="Ingrese su nombre(s)"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Apellidos</label>
                            <asp:TextBox CssClass="form-control" ID="txtApellidos" runat="server" placeholder="Ingrese sus apellidos"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Número telefónico/Celular</label>
                            <asp:TextBox CssClass="form-control" ID="txtTelefono" runat="server" placeholder="Ingrese su número telefónico o de Celular"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Documento de identidad</label>
                            <asp:TextBox CssClass="form-control" ID="txtIdentificacion" runat="server" placeholder="Ingrese su DNI o pasaporte"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Nombre del banco</label>
                            <asp:DropDownList CssClass="form-control" ID="lstBancos" runat="server" placeholder="Seleccione el banco"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Cuenta bancaria</label>
                            <asp:TextBox ID="txtCuentaBancaria" CssClass="form-control" runat="server" placeholder="Ingrese su cuenta bancaria"></asp:TextBox>
                        </div>
                        <asp:Button CssClass="btn btn-primary btn-block" ID="btnRegistrar" runat="server" Text="Registrar" type="button" OnClick="Event_RegisterUser"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
