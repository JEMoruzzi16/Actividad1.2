<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/HomeMesero.Master" AutoEventWireup="true" CodeBehind="HomeMesero.aspx.cs" Inherits="Web.HomeMesero1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="color:#000">

    <p class="h2" style="text-align:center"> Bienvenido al menu mesero! </p>
    <p class="h3" style="text-align:center">  </p>
    
    <p class="h2" style="text-align:center">MESAS</p>
    
    </div>

    <script>    
        
    </script>



    <div class="cards-container" style="display:flex;">
        
        <div class="mesa">
            <div class="card text-white <%if (lblmesaUnoEstado.Text == "Abierta")
                {%>bg-success mb-3<%}
                else
                {%> bg-danger<%} %>"  style="width: 18rem; text-align:center;">
              <div class="card-body">
                <h5 class="card-title" >Mesa 1</h5>
                  <asp:Label Text="Estado:"  runat="server" />
                  <asp:Label  id="lblmesaUnoEstado"  runat="server" ></asp:Label>        
                  <br />
                  <asp:Label Text="Capacidad:" runat="server" />
                  <asp:Label ID="lblCapacidad" runat="server" />
                  <br />
                  <br />
                  <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarUno" OnClick="btnGestionarUno_Click" runat="server" />
                  <br />
                  <br />
                  <asp:Button Text="Abrir Mesa" ID="btnAbrirUno" class="btn-primary" OnClick="btnAbrirUno_Click" runat="server" />  
              </div>
            </div>
        </div>

        <div class="mesa">
            <div class="card text-white <%if (lblMesaDosEstado.Text == "Abierta")
                {%> bg-success mb-3<%}
                else
                {%> bg-danger mb-3<%} %>" style="width: 18rem;text-align:center;">
              <div class="card-body">
                <h5 class="card-title">Mesa 2</h5>
                  <asp:Label Text="Estado:" runat="server" />
                  <asp:Label  id="lblMesaDosEstado"  runat="server" ></asp:Label>        
                  <br />
                  <asp:Label Text="Capacidad:" runat="server" />
                  <asp:Label ID="lblCapacidad2" runat="server" />
                  <br />
                  <br />
                  <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarDos" OnClick="btnGestionarDos_Click" runat="server" />
                  <br />
                  <br />
                  <asp:Button Text="Abrir Mesa" ID="btnAbrirDos" OnClick="btnAbrirDos_Click" class="btn-primary" runat="server" />
               </div>
            </div>
        </div>

        <div class="mesa">
            <div class="card text-white <%if (lblMesaTresEstado.Text == "Abierta")
                {%>bg-success<%}
                else
                { %> bg-danger mb-3<%} %> " style="width: 18rem;text-align:center;">
              <div class="card-body">
                <h5 class="card-title">Mesa 3</h5>
                <asp:Label Text="Estado:" runat="server" />
                <asp:Label  id="lblMesaTresEstado"  runat="server" ></asp:Label>        
                <br />
                <asp:Label Text="Capacidad:" runat="server" />
                <asp:Label ID="lblCapacidad3" runat="server" />
                <br />
                <br />
                <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarTres" OnClick="btnGestionarTres_Click"  runat="server" />
                <br />
                <br />
                <asp:Button Text="Abrir Mesa" ID="btnAbrirTres" OnClick="btnAbrirTres_Click" class="btn-primary" runat="server" />
              </div>
            </div>
        </div>

        <div class="mesa">
            <div class="card text-white <%if (lblMesaCuatroEstado.Text == "Abierta")
                {%> bg-success mb-3<%}
                else
                {%> bg-danger<%}%> " style="width: 18rem;text-align:center;">
              <div class="card-body">
                <h5 class="card-title">Mesa 4</h5>
                <asp:Label Text="Estado:" runat="server" />
                <asp:Label  id="lblMesaCuatroEstado"  runat="server" ></asp:Label>        
                <br />
                <asp:Label Text="Capacidad:" runat="server" />
                <asp:Label ID="lblCapacidad4" runat="server" />
                <br />
                <br />
                <asp:Button Text="Gestionar Pedido" class="btn-info" OnClick="btnGestionarCuatro_Click" ID="btnGestionarCuatro" runat="server" />
                <br />
                <br />
                <asp:Button Text="Abrir Mesa" ID="btnAbrirCuatro" OnClick="btnAbrirCuatro_Click" class="btn-primary" runat="server" />
              </div>
            </div>
        </div>
    </div>



    <div class="cards-container" style="display:flex;">
        <div class="mesa">
            <div class="card text-white <%if (lblMesaCincoEstado.Text == "Abierta")
                {%>bg-success mb-3<%}
                else
                {%> bg-danger<%} %>"  style="width: 18rem; text-align:center;">
                <div class="card-body">
                      <h5 class="card-title" >Mesa 5</h5>
                      <asp:Label Text="Estado:" runat="server" />
                      <asp:Label  id="lblMesaCincoEstado"  runat="server" ></asp:Label>        
                      <br />
                      <asp:Label Text="Capacidad:" runat="server" />
                      <asp:Label ID="lblCapacidad5" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarCinco" OnClick="btnGestionarCinco_Click" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Abrir Mesa" ID="btnAbrirCinco" class="btn-primary" OnClick="btnAbrirCinco_Click" runat="server" />  
                </div>
            </div>
        </div>


        <div class="mesa">
            <div class="card text-white <%if (lblMesaSeisEstado.Text == "Abierta")
                {%>bg-success mb-3<%}
                else
                {%> bg-danger<%} %>"  style="width: 18rem; text-align:center;">
                <div class="card-body">
                      <h5 class="card-title" >Mesa 6</h5>
                      <asp:Label Text="Estado:" runat="server" />
                      <asp:Label  id="lblMesaSeisEstado"  runat="server" ></asp:Label>        
                      <br />
                      <asp:Label Text="Capacidad:" runat="server" />
                      <asp:Label ID="lblCapacidad6" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarSeis" OnClick="btnGestionarSeis_Click" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Abrir Mesa" ID="btnAbrirSeis" class="btn-primary" OnClick="btnAbrirSeis_Click" runat="server" />  
                </div>
            </div>
        </div>
        

        <div class="mesa">
            <div class="card text-white <%if (lblMesaSieteEstado.Text == "Abierta")
                {%>bg-success mb-3<%}
                else
                {%> bg-danger<%} %>"  style="width: 18rem; text-align:center;">
                <div class="card-body">
                      <h5 class="card-title" >Mesa 7</h5>
                      <asp:Label Text="Estado:" runat="server" />
                      <asp:Label  id="lblMesaSieteEstado"  runat="server" ></asp:Label>        
                      <br />
                      <asp:Label Text="Capacidad:" runat="server" />
                      <asp:Label ID="lblCapacidad7" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarSiete" OnClick="btnGestionarSiete_Click" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Abrir Mesa" ID="btnAbrirSiete" class="btn-primary" OnClick="btnAbrirSiete_Click" runat="server" />  
                </div>
            </div>
        </div>
        

        <div class="mesa">
            <div class="card text-white <%if (lblMesaOchoEstado.Text == "Abierta")
                {%>bg-success mb-3<%}
                else
                {%> bg-danger<%} %>"  style="width: 18rem; text-align:center;">
                <div class="card-body">
                      <h5 class="card-title" >Mesa 8</h5>
                      <asp:Label Text="Estado:" runat="server" />
                      <asp:Label  id="lblMesaOchoEstado"  runat="server" ></asp:Label>        
                      <br />
                      <asp:Label Text="Capacidad:" runat="server" />
                      <asp:Label ID="lblCapacidad8" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Gestionar Pedido" class="btn-info" ID="btnGestionarOcho" OnClick="btnGestionarOcho_Click" runat="server" />
                      <br />
                      <br />
                      <asp:Button Text="Abrir Mesa" ID="btnAbrirOcho" class="btn-primary" OnClick="btnAbrirOcho_Click" runat="server" />  
                </div>
            </div>
        </div>
    </div>


   

</asp:Content>