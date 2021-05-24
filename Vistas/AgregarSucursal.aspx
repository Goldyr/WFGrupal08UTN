<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP8_GRUPO7.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlink_AgregarSucursal" runat="server" NavigateUrl="AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="hlink_ListarSucursal" runat="server" NavigateUrl="ListarSucursal.aspx">Listar Sucursal</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="hlink_EliminarSucursal" runat="server" NavigateUrl="EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
        </div>

        <h2>
            GRUPO NUMERO 7
        </h2>
        <h3>
            Agregar Sucursal
        </h3>
        <div>
            <div id="NomSuc">
                <p>Nombre Sucursal:</p>
                <asp:TextBox ID="txtbx_NombreSucursal" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Nombre" runat="server" ControlToValidate="txtbx_NombreSucursal" Visible="False">Ingresar nombre valido</asp:RequiredFieldValidator>
            </div>
            <div id="DescSuc">
                <p>Descripcion:</p>
                <asp:TextBox ID="txtbx_DescripcionSucursal" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Descripcion" runat="server" ControlToValidate="txtbx_DescripcionSucursal">Ingresar descripcion valida</asp:RequiredFieldValidator>
            </div>
            <div id="ProvSuc">
                <p>Provincia:</p>
                <asp:DropDownList ID="ddl_ProvinciaSucursal" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </div>
            <div id="DirSuc">
                <p>Direccion:</p>
                <asp:TextBox ID="txtbx_DireccionSucursal" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Direccion" runat="server" ControlToValidate="txtbx_DireccionSucursal">Ingresar una direccion valida</asp:RequiredFieldValidator>
            </div>
            <div id="BtnAceptar">
                <br />
                <asp:Button ID="btn_Aceptar" runat="server" Text="Aceptar" OnClick="btn_Aceptar_Click" />
                <br />
                <br />
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
