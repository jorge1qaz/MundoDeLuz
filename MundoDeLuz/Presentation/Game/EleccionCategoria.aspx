<%@ Page Title="Categoría" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EleccionCategoria.aspx.cs" Inherits="MundoDeLuz.Presentation.Game.EleccionCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <br />
        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-tittle">Elija una categoría</h5>
                        <br />
                        <div class="row">
                            <div class="col-sm-12 col-md-4">
                                <div class="card bg-light">
                                    <div class="card-body text-center">
                                        <h5 class="card-tittle">Básica </h5>
                                        <br />
                                        <a href="~/Presentation/Game/Dashboard.aspx?categoria=1" runat="server">Seleccionar</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-4">
                                <div class="card bg-light">
                                    <div class="card-body text-center">
                                        <h5 class="card-tittle">Intermedia </h5>
                                        <br />
                                        <a href="~/Presentation/Game/Dashboard.aspx?categoria=2" runat="server">Seleccionar</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-4">
                                <div class="card bg-light">
                                    <div class="card-body text-center">
                                        <h5 class="card-tittle">Avanzada</h5>
                                        <br />
                                        <a href="~/Presentation/Game/Dashboard.aspx?categoria=3" runat="server">Seleccionar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row" runat="server" id="boxAprobarMiembro">
                            <div class="col-sm-12 col-md-4">
                                <div class="card bg-light">
                                    <div class="card-body text-center">
                                        <h5 class="card-tittle">Aprobar  miembros </h5>
                                        <br />
                                        <a href="~/Presentation/Game/AprobarNodo.aspx" runat="server">Seleccionar</a>
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
