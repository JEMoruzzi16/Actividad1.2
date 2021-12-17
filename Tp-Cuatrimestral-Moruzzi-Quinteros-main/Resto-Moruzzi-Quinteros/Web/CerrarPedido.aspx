<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/HomeMesero.Master" AutoEventWireup="true" CodeBehind="CerrarPedido.aspx.cs" Inherits="Web.CerrarPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div id="container" style="text-align:center">
            <div style="color:black" class="border-secondary">

                <div>
                    <asp:Label runat="server" Text="Numero de Pedido"></asp:Label>
                    <asp:Label ID="lblNroPedido" runat="server" Text="$500" ></asp:Label>
                </div>

                <div>
                    <asp:Label runat="server" Text="Monto"></asp:Label>
                    <asp:Label ID="lblMonto" runat="server" Text="$500" ></asp:Label>
                </div>
                <div>
                    <asp:Label Text="Metodo de Pago" runat="server" />
                    <asp:DropDownList ID="ddlMetodoPago" runat="server"></asp:DropDownList>
                </div>
                <br />
                <div>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn-primary" OnClick="btnCancelar_Click"/>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn-primary" OnClick="btnAceptar_Click"/>
                </div>

            </div>
    </div>

</asp:Content>
