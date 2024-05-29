<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSurcursales.aspx.cs" Inherits="Vistas.ListadoDeSurcursales" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Listado de Sucursales</strong></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">Busqueda ingrese Id sucural:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtBusqueda" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todos" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="gdSucursales" runat="server">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
