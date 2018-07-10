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
                                        <h5 class="card-tittle">Esmeralda </h5>
                                        <label>S/ 10.00</label>
                                        <br />
                                        <a href="~/Presentation/Game/Dashboard.aspx?categoria=1" runat="server">Seleccionar</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-4">
                                <div class="card bg-light">
                                    <div class="card-body text-center">
                                        <h5 class="card-tittle">Rubí </h5>
                                        <label>S/ 50.00</label>
                                        <br />
                                        <a href="~/Presentation/Game/Dashboard.aspx?categoria=2" runat="server">Seleccionar</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-12 col-md-4">
                                <div class="card bg-light">
                                    <div class="card-body text-center">
                                        <h5 class="card-tittle">Zafiro </h5>
                                        <label>S/ 100.00</label>
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
                        <br />
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Datos de contacto</h5>
                                        <br />
                                        <table class="table">
                                            <tr>
                                                <td><b>Cuenta bancaria a depositar: </b></td>
                                                <td>770-7997651 ScotiaBank</td>
                                            </tr>
                                            <tr>
                                                <td><b>Correo de contacto:  </b></td>
                                                <td>mundodeluzoficial@gmail.com</td>
                                            </tr>
                                            <tr>
                                                <td><b>Número de contacto:  </b></td>
                                                <td>926 337 904</td>
                                            </tr>
                                        </table>
                                        <br />
                                        <b><em>Hacer el envío de la captura del voucher al correo o WhatsApp</em></b>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
