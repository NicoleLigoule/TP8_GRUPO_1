﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSurcursales.aspx.cs" Inherits="Vistas.ListadoDeSurcursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 28px;
        }
        .auto-style3 {
            height: 28px;
            font-size: x-large;
        }
        .auto-style4 {
            height: 33px;
        }
        .auto-style5 {
            width: 139px;
        }
        .auto-style6 {
            height: 28px;
            width: 139px;
        }
        .auto-style7 {
            height: 33px;
            width: 139px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoDeSurcursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar sucursal</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Listado de Sucursales</strong></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">Busqueda ingrese ID sucursal:&nbsp; </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todos" OnClick="btnMostrar_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="grdSucursales" runat="server">
                        </asp:GridView>
                        <br />
                    </td>
                    <td class="auto-style5">&nbsp;
                        <asp:Label runat="server" ID="lblMsgAdv" Text=" " ForeColor="Red"></asp:Label></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
