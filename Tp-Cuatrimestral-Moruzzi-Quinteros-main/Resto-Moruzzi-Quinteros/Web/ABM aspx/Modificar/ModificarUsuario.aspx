<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Site.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="Web.ABM_aspx.Modificar.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <p class="h2" style="text-align:center">Modificar Usuario</p>
    </div>
    <br />

    <div class="d-flex">

        <asp:TextBox ID="searchBox" runat="server" class="form-control me-2" type="search" placeholder="Ingrese nombre de Usuario" aria-label="Search"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-outline-success" type="submit" OnClick="btnBuscar_Click"/>
      </div>

    <br />
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
    </div>

        <div class="input-group mb-3">
          <label class="input-group-text" for="inputGroupSelect01">Tipo</label>
          
            <asp:DropDownList runat="server" id="ddlTipo" class="form-select" >
                <asp:ListItem Text="Gerente" />
                <asp:ListItem Text="Mesero" />
            </asp:DropDownList>
        </div>       

</asp:Content>
