<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="Web.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <div>
        <p class="h2" style="text-align:center">Agregar Nuevo Usuario</p>
    </div>
    <div class="container" style="width:60%" >
        <br />

        <div class="input-group mb-3">            
            <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="Nombre" aria-label="Recipient's username" aria-describedby="basic-addon2"></asp:TextBox>  
        </div>

        <div class="input-group mb-3">
            <asp:TextBox ID="txtApellido" runat="server" class="form-control" placeholder="Apellido" aria-label="Recipient's username" aria-describedby="basic-addon2"></asp:TextBox> 
        </div>

        <div class="input-group mb-3">          
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1"></asp:TextBox>  
        </div>


        <div class="input-group mb-3">
          <span class="input-group-text" id="basic-addon3">Contraseña</span>
            <asp:TextBox type="Password" ID="txtContrasena" runat="server" class="form-control" ></asp:TextBox>
        </div>

        <div class="input-group mb-3">          
            <asp:TextBox ID="txtFechaNac" runat="server" class="form-control" placeholder="Fecha de Nacimiento" aria-label="Recipient's username" aria-describedby="basic-addon2"></asp:TextBox>
        </div>

        <div class="input-group mb-3">
          <label class="input-group-text" for="inputGroupSelect01">Tipo</label>
          
            <asp:DropDownList runat="server" id="ddlTipo" class="form-select" >
                <asp:ListItem Text="Gerente" />
                <asp:ListItem Text="Mesero" />
            </asp:DropDownList>
        </div>       

        <div style="display:flex">
            <div style="margin-right:100px">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-outline-secondary" OnClick="btnAceptar_Click"/>
            </div>
            <div>
                <asp:Button ID="btnCancealar" runat="server" Text="Cancelar" class="btn btn-outline-secondary" OnClick="btnCancealar_Click2"  /> 
            </div>
        </div>
    </div>

</asp:Content>
