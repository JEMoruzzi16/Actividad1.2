<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="EliminarProducto.aspx.cs" Inherits="Web.EliminarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <div>
        <p class="h2" style="text-align:center">Eliminar Producto</p>
    </div>
    <div class="container" style="width:30%">
        <br />
        <div class="input-group mb-3">
            <label class="input-group-text" for="inputGroupSelect01">Categoria</label>
            <asp:DropDownList ID="ddlTipoProducto" class="form-select" AutoPostBack="true" OnSelectedIndexChanged="ddlTipoProducto_SelectedIndexChanged" runat="server"></asp:DropDownList>
        </div>
        <div class="input-group mb-3">
            <label class="input-group-text" for="inputGroupSelect01">Plato</label>
                <asp:DropDownList ID="ddlProducto" class="form-select" runat="server" ></asp:DropDownList>
        </div>
        <br />
        <div style="display: flex">
            <div style="margin-right:100px">
                <asp:Button ID="btnAceptar" Text="Aceptar" OnClick="btnAceptar_Click" class="btn btn-outline-secondary" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click" class="btn btn-outline-secondary" runat="server" />
            </div>
        </div>
    
    </div>
</asp:Content>
