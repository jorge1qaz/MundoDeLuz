<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="MundoDeLuz.Presentation.Game.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-tittle">Revisión de progreso</h5>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-light">
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
                        <div class="row">
                            <div class="col-md-9 col-sm-12">
                                <h5 class="card-tittle">Revisión de progreso para tus colaboradores</h5>
                            </div>
                            <div class="col-md-3 col-sm-12 text-center">
                                <button class="btn btn-info" type="button" id="btnTriggerPartner" data-toggle="modal" data-target="modalNewPartner">Agregar miembro</button>
                            </div>
                        </div>
                        <p>
                            Actualmente tienes a 
                            <asp:Label ID="PUlblCantidadColaboradores2" runat="server" Text="Label"></asp:Label>
                        </p>
                        <div class="row">
                            <div class="col-sm-4">
                                <div class="card">
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
                            <div class="col-sm-4">
                                <div class="card">
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
                            <div class="col-sm-4">
                                <div class="card">
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
                        </div>
                        <br />
                        <div class="row">
                            <div class="offset-sm-2 col-sm-4">
                                <div class="card">
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
                            <div class="col-sm-4">
                                <div class="card">
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
        
        <div class="modal fade bd-example-modal-sm" id="modalNewPartner" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title">Registro</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="card card-outline-secondary">
                            <div class="card-block bg-faded">
                                <div class="card-body">
                                    <label class="font-weight-bold">Registre un nuevo miembro</label>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-md-8 col-sm-12">
                                                <asp:TextBox CssClass="form-control" ID="txtAddPartner" runat="server" AutoCompleteType="Email" placeholder="Ingrese el correo electrónico del nuevo miembro"></asp:TextBox>
                                            </div>
                                            <div class="col-md-4 col-sm-12">
                                                <asp:Button ID="btnAddPartner" CssClass="btn btn-success form-control" runat="server" Text="Aceptar" OnClick="Event_AddNewPartner" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        $("#btnTriggerPartner").click(function () {
            $("#modalNewPartner").modal("show");
        });
    </script>
</asp:Content>
