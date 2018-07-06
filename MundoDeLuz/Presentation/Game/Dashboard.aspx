<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="MundoDeLuz.Presentation.Game.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-tittle">Revisión de progreso</h5>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-info text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="PUlblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>
                                                    <asp:Label ID="PUCategoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="PUlblNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="card">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Logros</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Próximo nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="PUlblSiguienteNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual colaboradores : </b></td>
                                                <td>
                                                    <asp:Label ID="PUlblCantidadColaboradores" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" class="text-center">
                                                    <h4>Dinero ganado: </h4>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b>
                                                        <asp:Label ID="GrlLblNombreNivel1" runat="server"></asp:Label>
                                                    </b>
                                                </td>
                                                <td>
                                                    <asp:Label ID="PULblGananciaNivel1" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b>
                                                        <asp:Label ID="GrlLblNombreNivel2" runat="server"></asp:Label>
                                                    </b>
                                                </td>
                                                <td>
                                                    <asp:Label ID="PULblGananciaNivel2" runat="server" Text="Label"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b>
                                                        <asp:Label ID="GrlLblNombreNivel3" runat="server"></asp:Label>
                                                    </b>
                                                </td>
                                                <td>
                                                    <asp:Label ID="PULblGananciaNivel3" runat="server" Text="Label"></asp:Label>
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
        <br />
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-tittle">Revisión de progreso para tus colaboradores</h5>
                        <p>Actualmente tienes a 
                            <asp:Label ID="PUlblCantidadColaboradores2" runat="server" Text="Label"></asp:Label>
                        </p>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-success text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="LN1lblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>
                                                    <asp:Label ID="LN1lblCategoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="LN1lblActualNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Colaboradores: </b></td>
                                                <td>
                                                    <asp:Label ID="LN1lblColaboradores" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="card bg-success text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="LN2lblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>
                                                    <asp:Label ID="LN2lblCategoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="LN2lblActualNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Colaboradores: </b></td>
                                                <td>
                                                    <asp:Label ID="LN2lblColaboradores" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-success text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="LN3lblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>
                                                    <asp:Label ID="LN3lblCategoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="LN3lblActualNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Colaboradores: </b></td>
                                                <td>
                                                    <asp:Label ID="LN3lblColaboradores" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="card bg-success text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="LN4lblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>
                                                    <asp:Label ID="LN4lblCategoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="LN4lblActualNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Colaboradores: </b></td>
                                                <td>
                                                    <asp:Label ID="LN4lblColaboradores" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-success text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>
                                                    <asp:Label ID="LN5lblNombres" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>
                                                    <asp:Label ID="LN5lblCategoria" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>
                                                    <asp:Label ID="LN5lblActualNivel" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td><b>Colaboradores: </b></td>
                                                <td>
                                                    <asp:Label ID="LN5lblColaboradores" runat="server"></asp:Label>
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
    </div>
    <br />

    new 
    <asp:TextBox ID="txtAddPartner" CssClass="form-control" runat="server"></asp:TextBox>


</asp:Content>
