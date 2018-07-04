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
                                                <td>2</td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual colaboradores : </b></td>
                                                <td>4</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <h4>Dinero ganado: </h4>
                                                </td>
                                                <td>
                                                    <h3>S/ 350</h3>
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
                        <p>Actualmente tienes a 3</p>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="card bg-success text-white">
                                    <div class="card-body">
                                        <h5 class="card-tittle">Miembro</h5>
                                        <table class="table">
                                            <tr>
                                                <td><b>Nombres: </b></td>
                                                <td>Sofía Ochoa de Romero</td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>Intermedio</td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>1</td>
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
                                                <td>Rosario Herrera Huaranga</td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>Intermedio</td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>1</td>
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
                                                <td>Luz Palomino Verástegui</td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>Básica</td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>1</td>
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
                                                <td>Sin asignar</td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>Sin asignar</td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>Sin asignar</td>
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
                                                <td>Sin asignar</td>
                                            </tr>
                                            <tr>
                                                <td><b>Categoría: </b></td>
                                                <td>Sin asignar</td>
                                            </tr>
                                            <tr>
                                                <td><b>Actual nivel: </b></td>
                                                <td>Sin asignar</td>
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
</asp:Content>
