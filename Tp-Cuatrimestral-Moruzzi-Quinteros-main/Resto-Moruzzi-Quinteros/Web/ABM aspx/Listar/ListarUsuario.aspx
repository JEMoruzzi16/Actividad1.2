<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="ListarUsuario.aspx.cs" Inherits="Web.ABM_aspx.Listar.ListarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

        <div>
            <p class="h2" style="text-align:center">Listar Usuario</p>
         </div>

        <asp:GridView ID="UsersView" runat="server"></asp:GridView>

</asp:Content>

