<%@ Page Title="Aprobar miembro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AprobarNodo.aspx.cs" Inherits="MundoDeLuz.Presentation.Game.AprobarNodo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <br />
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-tittle">Miembros a aprobar</h5>
                        <br />
                        <div class="card card-outline-success text-center">
                            <div class="card-block">
                                <div class="card-body">
                                    <table class="table table-striped table-bordered table-responsive">
                                        <thead>
                                            <tr>
                                                <th>Seleccione</th>
                                                <th>Nodo superior</th>
                                                <th>Nodo inferior</th>
                                                <th>Categoría</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <asp:DataList ID="dlstAprobarMiembro" runat="server" RepeatLayout="Flow" DataKeyField="IdProgreso" OnItemCommand="Event_SelectProgress">
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                            <asp:Button ID="btnSeleccionar" CssClass="btn btn-success" runat="server" Text="Seleccione" />
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="lblNodoSuperior" runat="server" Text='<%# Eval("NodoSuperior") %>'></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="lblNodoInferior" runat="server" Text='<%# Eval("NodoInferior") %>'></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="lblCategoria" runat="server" Text='<%# Eval("NombreCategoria") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:DataList>
                                        </tbody>
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
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
