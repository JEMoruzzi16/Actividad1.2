<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="AgregarTipoProducto.aspx.cs" Inherits="Web.AgregarTipoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        function validar() {
            var valido = true;
            var nombre = document.getElementById("txbNombre").value;

            if (nombre === "") {
                $("#txbNombre").removeClass("is-valid");
                $("#txbNombre").addClass("is-invalid");
                valido = false;
            } else {
                $("#txbNombre").removeClass("is-invalid");
                $("#txbNombre").addClass("is-valid");
            }
            if (!valido) {
                return valido;
            }
            return valido;
        }
    </script>

    <br />

    <div>
        <p class="h2" style="text-align:center">Nueva Categoría</p>
    </div>

    <br />
    
    <div class="container" style="width:28%">
          
        <div class="input-group mb-3">
            <asp:TextBox ID="txbNombre" class="form-control" placeholder="Nombre nueva Categoría" ClientIDMode="Static"
                aria-label="Recipient's categoria" aria-describedby="basic-addon2" runat="server"></asp:TextBox>
        </div>

        <div style="display:flex">
            <div style="padding-right:100px">
                <asp:Button ID="btnAceptar" Text="Aceptar" class="btn btn-outline-secondary" 
                     OnClientClick="return validar()" OnClick="btnAceptar_Click" runat="server"  />
            </div>
            <div>
                <asp:Button ID="btnCancelar" Text="Cancelar" class="btn btn-outline-secondary"  OnClick="btnCancelar_Click" runat="server" />
            </div>
    
         </div>
    
    </div>
</asp:Content>
