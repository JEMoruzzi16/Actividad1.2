<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="Web.AgregarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <script>
        function validar() {
            var valido = true;
            var precio = document.getElementById("txtPrecio").value;
            var stock = document.getElementById("txtStock").value;
            var plato = document.getElementById("txtNombrePlato").value;

            if (precio === "") {
                $("#txtPrecio").removeClass("is-valid");
                $("#txtPrecio").addClass("is-invalid");
                valido = false;
            } else {
                $("#txtPrecio").removeClass("is-invalid");
                $("#txtPrecio").addClass("is-valid");
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
                $("#txtNombrePlato").removeClass("is-valid");
                $("#txtNombrePlato").addClass("is-invalid");
                valido = false;
            } else {
                $("#txtNombrePlato").removeClass("is-invalid");
                $("#txtNombrePlato").addClass("is-valid");
            }

            if (!valido) {
                return valido;
            }

            return valido;
        }
    </script>  
    
    <br />
    <div>
        <p class="h2" style="text-align:center">Agregar Nuevo Plato:</p>
    </div>

    <div class="container" style="width:30%">
    
        <br />        
        <div class="input-group mb-3">
            <label class="input-group-text" for="inputGroupSelect01">Categoría</label>
            <asp:DropDownList ID="ddlTipoProducto" class="form-select" ClientIDMode="Static" AutoPostBack="true" runat="server" 
                OnSelectedIndexChanged="ddlTipoProducto_SelectedIndexChanged" >
                <asp:ListItem Text="Seleccione" Value="-1"></asp:ListItem>
            </asp:DropDownList>
        </div>

            <%/* %>
        <div>
            <asp:DropDownList ID="ddlProducto" AutoPostBack="false" runat="server"></asp:DropDownList>
        </div>
            <%*/ %>

        <div class="input-group mb-3">
            <asp:TextBox ID="txtPrecio" runat="server" class="form-control" ClientIDMode="Static" placeholder="Precio" 
                aria-label="Recipient's producto" aria-describedby="basic-addon2" ></asp:TextBox>
            <asp:RangeValidator ErrorMessage="Ingrese un valor entre 1 y 3000" ControlToValidate="txtPrecio" 
                MaximumValue="3000" MinimumValue="1" runat="server" />
        </div>

        <div class="input-group mb-3">
            <asp:TextBox ID="txtStock" runat="server" class="form-control" ClientIDMode="Static" placeholder="Stock"
                aria-label="Recipient's producto" aria-describedby="basic-addon2" ></asp:TextBox>
             <asp:RangeValidator ErrorMessage="Ingrese un valor entre 1 y 1000"  ControlToValidate="txtStock" 
                MaximumValue="1000" MinimumValue="1" runat="server" />
        </div>
 
        <div class="input-group mb-3">
            <asp:TextBox ID="txtNombrePlato" runat="server" class="form-control" ClientIDMode="Static" placeholder="Plato" 
                aria-label="Recipient's producto" aria-describedby="basic-addon2" MaxLength="50"></asp:TextBox>
        </div>
        
        <br />
        <br />

        <div style="display:flex">
            <div style="margin-right:100px">
            <asp:Button ID="btnAceptar" Text="Aceptar" OnClientClick="return validar()"
                OnClick="btnAceptar_Click" class="btn btn-outline-secondary" runat="server" />
            </div>
            <div>
            <asp:Button ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click" class="btn btn-outline-secondary"
                runat="server" />
            </div>
        </div>

    </div>

</asp:Content>
