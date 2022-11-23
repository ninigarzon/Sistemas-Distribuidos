<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages.Master" AutoEventWireup="true" CodeBehind="GestionProducto.aspx.cs" Inherits="Guia5.Pages.Administracion.GestionProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content">
        <p>Nombre</p>
        <p>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </p>
        <p>Tipo</p>
        <p>
            <asp:DropDownList ID="ddITipo" runat="server" DataTextField="Nombre" DataValueField="ID" DataSourceID="SqlDataSource1"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [TipoProducto] ORDER BY [Nombre]"></asp:SqlDataSource>
        </p>
        <p>Precio</p>
        <p>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
        </p>
        <p>Imagen</p>
        <p>
            <asp:DropDownList ID="ddImagen" runat="server"></asp:DropDownList>
        </p>
        <p>Descripcion</p>
        <p>
            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Width="100px" Wrap="True"></asp:TextBox>
        </p>
        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"/>
        <p>
            <asp:Label ID="lb1Result" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
</asp:Content>
