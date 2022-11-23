<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages.Master" AutoEventWireup="true" CodeBehind="GestionTipoProducto.aspx.cs" Inherits="Guia5.Pages.Administracion.GestionTipoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p>Nombre</p>
<p>
    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"/>
</p>
<p>
    <asp:Label ID="Lb1Result" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>

