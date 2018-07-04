<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="MundoDeLuz.Presentation.Messages.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <br />
        <br />
        <div class="row align-items-center">
            <div class="col-md-12">
                <div class="card card-outline-secondary text-center">
                    <div class="card-block">
                        <h4 class="card-title">
                            <asp:Label ID="lblHeader" runat="server" Text="Label"></asp:Label></h4>
                        <div class="row justify-content-center">
                            <div class="col-md-8"><i class="material-icons text-danger" style="font-size: 160px;">error_outline</i></div>
                        </div>
                        <div class="row justify-content-center">
                            <div class="col-md-8">
                                <div class="card bg-danger text-white">
                                    <div class="card-block">
                                        <asp:Label ID="lblMensajePrincipal" runat="server" Text="Label"></asp:Label>
                                        <br />
                                        <asp:LinkButton ID="linkButton" runat="server" CssClass="btn btn-primary">Inicio</asp:LinkButton>
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
</asp:Content>
