<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailProgress.aspx.cs" Inherits="MundoDeLuz.Presentation.Game.DetailProgress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-tittle">Aprobar o anular registro de miembro</h5>
                        <em>Categoría: 
                            <asp:Label ID="lblCategoria" runat="server"></asp:Label>
                        </em>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-light">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro en nodo superior</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="NSlblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Apellidos: </b></td>
                                                <td>
                                                    <asp:Label ID="NSlblApellidos" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Número Telefónico: </b></td>
                                                <td>
                                                    <asp:Label ID="NSlblTelefono" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Email: </b></td>
                                                <td>
                                                    <asp:Label ID="NSlblIdUsuario" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="card bg-light">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro en nodo inferior</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="NIlblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Apellidos: </b></td>
                                                <td>
                                                    <asp:Label ID="NIlblApellidos" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Número Telefónico: </b></td>
                                                <td>
                                                    <asp:Label ID="NIlblTelefono" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Email: </b></td>
                                                <td>
                                                    <asp:Label ID="NIlblIdUsuario" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">   
            <div class="col-sm-6 text-center">
                <asp:Button CssClass="btn btn-danger" ID="btnRechazar" runat="server" Text="Rechazar" OnClick="Event_Rechazar" />
            </div>
            <div class="col-sm-6 text-center">
                <asp:Button CssClass="btn btn-success" ID="btnAceptar" runat="server" Text="Aceptar" OnClick="Event_Aceptar" />
            </div>
        </div>
    </div>
</asp:Content>
