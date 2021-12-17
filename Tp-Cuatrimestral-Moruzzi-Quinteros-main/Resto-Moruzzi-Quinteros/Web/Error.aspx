<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/Login.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Web.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="color:#ffffff;text-align:center; flex">
        <p class="h2" >Ups..Hubo un problema</p>
        <asp:Label Text="text" ID="lblMensaje" runat="server"/>
    </div>
    <br />
    <br />
    <br />
    <div class="mb-5" style="padding-left:550px">
        <asp:Button Text="Volver" ID="btnCancelar" class="btn btn-primary w-100" 
          OnClick="btnCancelar_Click"   runat="server" />
    </div>
</asp:Content>
