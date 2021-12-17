<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="ModificarProducto.aspx.cs" Inherits="Web.ModificarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <script>
        function validar() {
            var valido = true;
            var precio = document.getElementById("txbPrecio").value;
            var stock = document.getElementById("txtStock").value;
            var plato = document.getElementById("txtNombre").value;

            if (precio === "") {
                $("#txbPrecio").removeClass("is-valid");
                $("#txbPrecio").addClass("is-invalid");
                valido = false;
            } else {
                $("#txbPrecio").removeClass("is-invalid");
                $("#txbPrecio").addClass("is-valid");
            }
            if (stock === "") {
                $("#txtStock").removeClass("is-valid");
                $("#txtStock").addClass("is-invalid");
                valido = false;
            } else {
                $("#txtStock").removeClass("is-invalid");
                $("#txtStock").addClass("is-valid");
            }
            if (plato === "") {
                $("#txtNombre").removeClass("is-valid");
                $("#txtNombre").addClass("is-invalid");
                valido = false;
            } else {
                $("#txtNombre").removeClass("is-invalid");
                $("#txtNombre").addClass("is-valid");
            }
            if (!valido) {
                return valido;
            }

            return valido;
        }
    </script>
    
    <br />
    <div>
        <p class="h2" style="text-align:center">Modificar Plato</p>
    </div>

    <div class="container" style="width:30%">
        <br />

        <div class="input-group mb-3">
         <label class="input-group-text" for="inputGroupSelect01">Categoría</label>
            <asp:DropDownList id="ddlTipoProducto" AutoPostBack="true" class="form-select" 
             OnSelectedIndexChanged="ddlTipoProducto_SelectedIndexChanged"  runat="server" ></asp:DropDownList>
        </div>
        
        <div class="input-group mb-3">
            <label class="input-group-text" for="inputGroupSelect01">Plato</label>
            <asp:DropDownList ID="ddlProducto" class="form-select" runat="server" ></asp:DropDownList>
        </div>

        <div class="input-group mb-3">
            <asp:TextBox ID="txbPrecio" class="form-control" placeholder="Precio" ClientIDMode="Static"
                aria-label="Recipient's producto" aria-describedby="basic-addon2" runat="server" />
            <asp:RangeValidator ErrorMessage="Ingrese un valor entre 1 y 3000" ControlToValidate="txbPrecio" 
                MaximumValue="3000" MinimumValue="1" runat="server" />
        </div>

        <div class="input-group mb-3">
            <asp:TextBox ID="txtStock" class="form-control" placeholder="Stcok" ClientIDMode="Static"
              aria-label="Recipient's producto" aria-describedby="basic-addon2" runat="server" />
             <asp:RangeValidator ErrorMessage="Ingrese un valor entre 1 y 1000"  ControlToValidate="txtStock" 
                MaximumValue="1000" MinimumValue="1" runat="server" />
        </div>

        <div class="input-group mb-3">
            <asp:TextBox ID="txtNombre" class="form-control" placeholder="Nombre" ClientIDMode="Static"
               aria-label="Recipient's producto" aria-describedby="basic-addon2" runat="server" MaxLength="50" />
        </div>

        <div style="display:flex">
            <div style="margin-right:130px">
            <asp:Button Id="btnAceptar" Text="Aceptar" class="btn btn-outline-secondary" OnClientClick="return validar()" OnClick="btnAceptar_Click" runat="server" />
            </div>
            <div>
                <asp:Button Id="btnCancelar" Text="Cancelar" class="btn btn-outline-secondary"  OnClick="btnCancelar_Click" runat="server" />
            </div>
        </div>

    </div>
    
</asp:Content>
