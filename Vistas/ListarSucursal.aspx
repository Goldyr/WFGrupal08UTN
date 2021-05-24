<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursal.aspx.cs" Inherits="TP8_GRUPO7.ListarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlink_AgregarSucursal" runat="server" NavigateUrl="AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="hlink_ListarSucursal" runat="server" NavigateUrl="ListarSucursal.aspx">Listar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="hlink_EliminarSucursal" runat="server" NavigateUrl="EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
            <br />
            <br />
            <span class="auto-style1"><strong>Listado de Sucursales</strong><br />
            </span>&nbsp;<br />
            Busqueda ingrese ID sucursal:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSucursal" runat="server" TextMode="Number" ValidationGroup="busqueda1"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" ValidationGroup="busqueda1" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todos" OnClick="btnMostrar_Click" />
            <asp:Label ID="lbl_inexistente" runat="server" Text="La sucursal no existe" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="grdDatos" runat="server">
            </asp:GridView>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
