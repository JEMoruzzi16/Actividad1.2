<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="EliminarTipoProducto.aspx.cs" Inherits="Web.ABM_aspx.Eliminar.EliminarTipoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div>
        <p class="h2" style="text-align:center"> Eliminar Categoría</p>
    </div>
    <br />
    <div class="container" style="width:30%">
            <div class="input-group mb-3">
                <label class="input-group-text" for="inputGroupSelect01">Categoría</label>
                <asp:DropDownList Id="ddlTipo" class="form-select" AutoPostBack="false" runat="server"> </asp:DropDownList>
            </div>
            <br />
            
            <div style="display:flex">
                <div style="margin-right:100px">
                    <asp:Button id="btnEliminar" class="btn btn-outline-secondary" OnClick="btnEliminar_Click" Text="Eliminar" runat="server" />
                </div>
                <div>
                    <asp:Button ID="btnCancelar" Text="Cancelar" class="btn btn-outline-secondary" OnClick="btnCancelar_Click" runat="server" />
                </div>
            </div>
    </div>
</asp:Content>
