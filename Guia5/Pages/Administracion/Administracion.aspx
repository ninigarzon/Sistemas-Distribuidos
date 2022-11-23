﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Guia5.Administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton runat="server" CssClass="button" Text="Adicionar Nuevo Producto" ID="LinkButton1" PostBackUrl="~/Pages/Administracion/GestionProducto.aspx">Adicionar Nuevo Producto</asp:LinkButton>
    <asp:GridView ID="grdProductos" runat="server" DataSourceID="sdsProductos" AutoGenerateColumns="True" DataKeyNames="ID" AllowPaging="True" AllowSorting="True" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" ShowHeaderWhenEmpty="True" AutoGenerateSelectButton="False" EnablePersistedSelection="True"></asp:GridView><asp:SqlDataSource runat="server" ID="SqlDataSource1"></asp:SqlDataSource>
    <asp:SqlDataSource runat="server" ID="sdsProductos" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Producto] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Producto] ([TipoID], [Nombre], [Precio], [Descripcion], [Imagen]) VALUES (@TipoID, @Nombre, @Precio, @Descripcion, @Imagen)" SelectCommand="SELECT * FROM [Producto]" UpdateCommand="UPDATE [Producto] SET [TipoID] = @TipoID, [Nombre] = @Nombre, [Precio] = @Precio, [Descripcion] = @Descripcion, [Imagen] = @Imagen WHERE [ID] = @ID"></asp:SqlDataSource>
    <asp:LinkButton ID="LinkButton2" CssClass="button" Text="Adicionar Nuevo tipo Producto" runat="server" PostBackUrl="~/Pages/Administracion/GestionTipoProducto.aspx">Adicionar tipo de productos</asp:LinkButton>
    <asp:GridView ID="grdProductosTipo" runat="server" DataSourceID="sdsTiposProductos" AutoGenerateColumns="True" DataKeyNames="ID" AllowPaging="True" AllowSorting="True" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" ShowHeaderWhenEmpty="True"></asp:GridView>
    <asp:SqlDataSource runat="server" ID="sdsTiposProductos" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [TipoProducto] WHERE [ID] = @ID" InsertCommand="INSERT INTO [TipoProducto] ([Nombre]) VALUES (@Nombre)" SelectCommand="SELECT * FROM [TipoProducto]" UpdateCommand="UPDATE [TipoProducto] SET [Nombre] = @Nombre WHERE [ID] = @ID"></asp:SqlDataSource>
</asp:Content>
