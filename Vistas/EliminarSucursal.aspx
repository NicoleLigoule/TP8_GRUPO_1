<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
            width: 283px;
        }
        .auto-style3 {
            width: 283px;
        }
        .auto-style4 {
            width: 145px;
        }
        .auto-style5 {
            color: #FF3300;
        }
        .auto-style6 {
            width: 167px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoDeSurcursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar sucursal</asp:HyperLink>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Eliminar Sucursal</strong></td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Ingresar ID Sucursal:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtEliminarSucu" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnEliminar" runat="server" Height="32px" Text="Eliminar" Width="82px" />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvCompletar" runat="server" ControlToValidate="txtEliminarSucu">Debe completar el campo para poder eliminar una Sucursal</asp:RequiredFieldValidator>
                        <br />
                        <br />
                        <asp:RegularExpressionValidator ID="revNumeros" runat="server" ControlToValidate="txtEliminarSucu" ValidationExpression="^\d+$">Solo se permiten números</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="auto-style5"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
