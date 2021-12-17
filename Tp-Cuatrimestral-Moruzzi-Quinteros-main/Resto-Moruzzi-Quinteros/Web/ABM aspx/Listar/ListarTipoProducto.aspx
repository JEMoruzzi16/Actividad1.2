<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="ListarTipoProducto.aspx.cs" Inherits="Web.ABM_aspx.Listar.ListarTipoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div>
        <p class="h2" style="text-align:center">Listar Categorias</p>
    </div>
    <div class="container" style="width:30%">
        <br />
        <div class="input-group mb-3">
                <asp:GridView ID="dgvTipoDeProducto" class="form-select" runat="server"></asp:GridView>
            
        </div>
        <br />
        <div style="display:flex">
            <div style="margin-right:100px">
                <asp:Button ID="btnCancelar" Text="Volver" class="btn btn-outline-secondary" OnClick="btnCancelar_Click" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnNuevoTipo" Text="Nueva Categoría"  class="btn btn-outline-secondary" OnClick="btnNuevoTipo_Click"  runat="server" />
            </div>
        </div>


    </div>
</asp:Content>
